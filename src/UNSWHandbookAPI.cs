using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace UNSW_Handbook_API
{
    static class UNSWHandbookAPI
    {
        public enum StudyLevel
        {
            Undergraduate,
            Postgraduate
        }

        private static string StudyLevelString(StudyLevel studyLevel)
        {
            switch (studyLevel)
            {
                case StudyLevel.Undergraduate:
                    return "undergraduate";
                case StudyLevel.Postgraduate:
                    return "postgraduate";// check this name and any others
            }

            throw new NotImplementedException("Study level string has fewer cases than the Study Level enumeration.");
        }

        public static async Task<Subject> GetSubject(string subjectCode, StudyLevel studyLevel, int year = 0)
        {
            year = year == 0 ? DateTime.Now.Year : year;

            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync($"https://www.handbook.unsw.edu.au/api/content/render/false/query/+contentType:unsw_psubject%20+unsw_psubject.studyLevelURL:{StudyLevelString(studyLevel)}%20+unsw_psubject.implementationYear:{year}%20+unsw_psubject.code:{subjectCode}%20+deleted:false%20+working:true%20+live:true%20+languageId:1%20/orderBy/modDate%20desc");

            if (response.IsSuccessStatusCode)
            {
                SubjectResponse subjectResponse =
                        JsonConvert.DeserializeObject<SubjectResponse>(
                            await response.Content.ReadAsStringAsync());

                SubjectResponse.Data subjectData = JsonConvert.DeserializeObject<SubjectResponse.Data>(subjectResponse.contentlets.First().data);

                Subject subject = new Subject()
                {
                    Name = subjectData.title,
                    Code = subjectData.code,
                    UOC = Convert.ToUInt16(subjectData.credit_points),
                    OfferingFaculty = subjectData.parent_academic_org.value
                };

                subject.Exclusions = new List<string>();

                foreach (SubjectResponse.Exclusion exclusion in subjectData.exclusion)
                {
                    subject.Exclusions.Add(exclusion.assoc_short_title);
                }

                subject.OfferingTerms =
                        subjectData.offering_detail.offering_terms
                            .Split(",")
                            .Select(x => x.Trim())
                            .ToList();

                subject.ConditionsOfEnrolment = new List<string>();

                foreach (SubjectResponse.EnrolmentRule enrolmentRule in subjectData.enrolment_rules)
                {
                    subject.ConditionsOfEnrolment.Add(
                        Regex.Replace(enrolmentRule.description, "<[^>]+>", ""));
                }

                return subject;
            }
            else
            {
                throw new Exception($"UNSW Handbook responded with status code {response.StatusCode} and body {await response.Content.ReadAsStringAsync()}");
            }
        }

        public static async Task<Program> GetProgram(string subjectCode, StudyLevel studyLevel, int year = 0)
        {
            year = year == 0 ? DateTime.Now.Year : year;

            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync($"https://www.handbook.unsw.edu.au/api/content/render/false/query/+contentType:unsw_pcourse%20+unsw_pcourse.studyLevelURL:{StudyLevelString(studyLevel)}%20+unsw_pcourse.implementationYear:{year}%20+unsw_pcourse.code:{subjectCode}%20+conHost:f59fc109-4aaa-40e0-bdcc-7039d31533f8%20+deleted:false%20+working:true%20+live:true%20+languageId:1%20/orderBy/modDate%20desc");



            //Console.WriteLine(response.StatusCode);
            //Console.WriteLine(await response.Content.ReadAsStringAsync());

            if (response.IsSuccessStatusCode)
            {
                ProgramResponse programResponse =
                        JsonConvert.DeserializeObject<ProgramResponse>(
                            await response.Content.ReadAsStringAsync());

                ProgramResponse.Data programData = JsonConvert.DeserializeObject<ProgramResponse.Data>(programResponse.contentlets.First().data);
                //ProgramResponse.CurriculumStructure programCurriculumStructure = JsonConvert.DeserializeObject<ProgramResponse.CurriculumStructure>(programResponse.contentlets.First().data);

                //Console.WriteLine(JsonConvert.SerializeObject(programData));

                Program program = new Program()
                {
                    Name = programData.title,
                    Description = Regex.Replace(programData.description, "<[^>]+>", ""),
                    AwardTitle = Regex.Replace(programResponse.contentlets[0].awardTitle, "<[^>]+>", ""),
                    Keywords = programResponse.contentlets.First().keywords.Split(",").ToList()
                };

                return program;
            }
            else
            {
                throw new Exception($"UNSW Handbook responded with status code {response.StatusCode} and body {await response.Content.ReadAsStringAsync()}");
            }
        }
    }
}
