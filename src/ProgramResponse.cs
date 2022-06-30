using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNSW_Handbook_API
{
    

    internal class ProgramResponse
    {
        public List<Contentlet> contentlets { get; set; }

        internal class StudyLevel
        {
            public string label { get; set; }
            public string value { get; set; }
        }

        internal class AscedDetailed
        {
            public string value { get; set; }
            public string cl_id { get; set; }
            public string key { get; set; }
        }

        internal class AscedBroad
        {
            public string value { get; set; }
            public string cl_id { get; set; }
            public string key { get; set; }
        }

        internal class OwningOrg
        {
            public string value { get; set; }
            public object cl_id { get; set; }
            public string key { get; set; }
        }

        internal class PublishedInHandbook
        {
            public string label { get; set; }
            public string value { get; set; }
        }

        internal class AcademicOrg
        {
            public string value { get; set; }
            public string cl_id { get; set; }
            public string key { get; set; }
        }

        internal class ParentAcademicOrg
        {
            public string value { get; set; }
            public string cl_id { get; set; }
            public string key { get; set; }
        }

        internal class InternationalAvailabilityClarification
        {
            public string value { get; set; }
            public object cl_id { get; set; }
            public string key { get; set; }
        }

        internal class DurationPtPeriod
        {
            public object label { get; set; }
            public object value { get; set; }
        }

        internal class Location
        {
            public string value { get; set; }
            public object cl_id { get; set; }
            public string key { get; set; }
        }

        internal class Subclass
        {
            public string label { get; set; }
            public string value { get; set; }
        }

        internal class EnrolmentRestrictions
        {
            public string value { get; set; }
            public object cl_id { get; set; }
            public string key { get; set; }
        }

        internal class IntakePeriod
        {
            public string value { get; set; }
            public string cl_id { get; set; }
            public string key { get; set; }
        }

        internal class AscedNarrow
        {
            public string value { get; set; }
            public string cl_id { get; set; }
            public string key { get; set; }
        }

        internal class DurationFtPeriod
        {
            public object label { get; set; }
            public object value { get; set; }
        }

        internal class AcademicCalendar
        {
            public string value { get; set; }
            public string cl_id { get; set; }
            public string key { get; set; }
        }

        internal class Status
        {
            public object label { get; set; }
            public object value { get; set; }
        }

        internal class Hbetype
        {
            public object label { get; set; }
            public object value { get; set; }
        }

        internal class Category
        {
            public object label { get; set; }
            public object value { get; set; }
        }

        internal class CourseVersion
        {
            public string value { get; set; }
            public string cl_id { get; set; }
            public string key { get; set; }
        }

        internal class AwardAqf
        {
            public string label { get; set; }
            public string value { get; set; }
        }

        internal class AcademicItem
        {
            public string value { get; set; }
            public string cl_id { get; set; }
            public string key { get; set; }
        }

        internal class AwardType
        {
            public string label { get; set; }
            public string value { get; set; }
        }

        internal class HbAward
        {
            public AwardAqf award_aqf { get; set; }
            public AcademicItem academic_item { get; set; }
            public AwardType award_type { get; set; }
            public string award_title { get; set; }
            public string award_abbreviation { get; set; }
            public string cl_id { get; set; }
        }

        internal class HbHandbookEntry
        {
            public object html { get; set; }
            public Status status { get; set; }
            public string cl_id { get; set; }
            public string value2 { get; set; }
            public string link_url { get; set; }
            public AcademicItem academic_item { get; set; }
            public string hbeorder { get; set; }
            public string text { get; set; }
            public Hbetype hbetype { get; set; }
            public string handbook_entry_field_content { get; set; }
            public string heading { get; set; }
            public Category category { get; set; }
            public string value1 { get; set; }
            public string handbook_code { get; set; }
        }

        internal class Type
        {
            public string label { get; set; }
            public string value { get; set; }
        }

        internal class HbCode
        {
            public string code { get; set; }
            public Type type { get; set; }
            public string cl_id { get; set; }
        }

        internal class Mode
        {
            public string value { get; set; }
            public string cl_id { get; set; }
            public string key { get; set; }
        }

        internal class AdmissionCalendar
        {
            public object label { get; set; }
            public object value { get; set; }
        }

        internal class LanguageOfInstruction
        {
            public string label { get; set; }
            public string value { get; set; }
        }

        internal class AttendanceType
        {
            public string label { get; set; }
            public string value { get; set; }
        }

        internal class Offering
        {
            public Mode mode { get; set; }
            public AdmissionCalendar admission_calendar { get; set; }
            public string clarification_to_appear_in_handbook { get; set; }
            public string start_date { get; set; }
            public string end_date { get; set; }
            public string comments { get; set; }
            public LanguageOfInstruction language_of_instruction { get; set; }
            public string ext_id { get; set; }
            public string publish { get; set; }
            public Status status { get; set; }
            public string offered { get; set; }
            public string linking_id { get; set; }
            public string cl_id { get; set; }
            public string display_name { get; set; }
            public Location location { get; set; }
            public string name { get; set; }
            public string order { get; set; }
            public List<AttendanceType> attendance_type { get; set; }
            public AcademicItem academic_item { get; set; }
            public string year { get; set; }
            public string entry_point { get; set; }
        }

        internal class Child
        {
            public string value { get; set; }
            public string cl_id { get; set; }
            public string key { get; set; }
            public string type { get; set; }
        }

        internal class ParentClId
        {
            public string value { get; set; }
            public string cl_id { get; set; }
            public string key { get; set; }
            public string type { get; set; }
        }

        internal class GaMap
        {
            public Child child { get; set; }
            public string child_table { get; set; }
            public ParentClId parent_cl_id { get; set; }
            public string parent_table { get; set; }
            public string map_title { get; set; }
            public string cl_id { get; set; }
            public string title { get; set; }
        }

        internal class LearningOutcome
        {
            public string number { get; set; }
            public string order { get; set; }
            public string linking_id { get; set; }
            public List<object> offerings { get; set; }
            public string lo_cl_id { get; set; }
            public AcademicItem academic_item { get; set; }
            public List<object> lo_domain { get; set; }
            public string code { get; set; }
            public string description { get; set; }
            public string cl_id { get; set; }
            public List<GaMap> ga_map { get; set; }
        }

        internal class StudyLevelSingle
        {
            public string label { get; set; }
            public string value { get; set; }
        }

        internal class OfferingDetail
        {
            public string label { get; set; }
            public string value { get; set; }
        }

        internal class DependentType
        {
            public object label { get; set; }
            public object value { get; set; }
        }

        internal class AiClId
        {
            public string value { get; set; }
            public string cl_id { get; set; }
            public string key { get; set; }
        }

        internal class AssociationType
        {
            public string label { get; set; }
            public string value { get; set; }
        }

        internal class AssociatedAiClId
        {
            public string value { get; set; }
            public string cl_id { get; set; }
            public string key { get; set; }
        }

        internal class AssocCurrentVersion
        {
        }

        internal class AssociatedProgram2
        {
            public DependentType dependent_type { get; set; }
            public AiClId ai_cl_id { get; set; }
            public AssociationType association_type { get; set; }
            public string association_desc { get; set; }
            public AssociatedAiClId associated_ai_cl_id { get; set; }
            public string cl_id { get; set; }
            public string assoc_credit_points { get; set; }
            public string assoc_active { get; set; }
            public string assoc_title { get; set; }
            public string assoc_cl_id { get; set; }
            public string assoc_short_title { get; set; }
            public string assoc_campus { get; set; }
            public string assoc_url { get; set; }
            public string assoc_class { get; set; }
            public string assoc_award_titles { get; set; }
            public string assoc_state { get; set; }
            public string assoc_award_single { get; set; }
            public string assoc_code { get; set; }
            public string assoc_class_translated_subjects { get; set; }
            public string assoc_faculty { get; set; }
            public string assoc_class_translated { get; set; }
            public string assoc_duration_hb_display { get; set; }
            public AssocCurrentVersion assoc_current_version { get; set; }
            public List<object> links { get; set; }
            public List<object> associated_programs { get; set; }
        }

        internal class EnrolmentRule
        {
            public string active { get; set; }
            public AcademicItem academic_item { get; set; }
            public Type type { get; set; }
            public string order { get; set; }
            public string cl_id { get; set; }
            public string description { get; set; }
            public List<object> links { get; set; }
        }

        internal class HbEnrolmentRule
        {
            public string type { get; set; }
            public List<EnrolmentRule> enrolment_rule { get; set; }
        }

        internal class Domain
        {
            public string label { get; set; }
            public string value { get; set; }
        }

        internal class Requirement
        {
            public Domain domain { get; set; }
            public Type type { get; set; }
            public string description { get; set; }
            public string cl_id { get; set; }
            public List<object> links { get; set; }
        }

        internal class EntryRequirementsV2
        {
            public string domain { get; set; }
            public List<Requirement> requirements { get; set; }
        }

        internal class SpecialAdmissionRequirementsV2
        {
            public string domain { get; set; }
            public List<Requirement> requirements { get; set; }
        }

        internal class Parent
        {
            public string value { get; set; }
            public object cl_id { get; set; }
            public string key { get; set; }
        }

        internal class FacultyDetail
        {
            public string cl_id { get; set; }
            public PublishedInHandbook published_in_handbook { get; set; }
            public string name { get; set; }
            public string ext_id { get; set; }
            public string active { get; set; }
            public Parent parent { get; set; }
            public string code { get; set; }
            public string description { get; set; }
            public string url { get; set; }
            public string name_url { get; set; }
            public string name_no_url { get; set; }
            public List<object> links { get; set; }
        }

        internal class Title
        {
            public string text { get; set; }
            public int order { get; set; }
        }

        internal class Content
        {
            public string text { get; set; }
            public int order { get; set; }
        }

        internal class Row
        {
            public int order { get; set; }
            public Title title { get; set; }
            public List<Content> content { get; set; }
            public List<object> links { get; set; }
        }

        internal class RecognitionOfAchievements
        {
            public Title title { get; set; }
            public string cardtitle { get; set; }
            public string cardsubtitle { get; set; }
            public List<Row> rows { get; set; }
            public List<object> content { get; set; }
        }

        internal class Data
        {
            public string implementation_year { get; set; }
            public string is_multi_award { get; set; }
            public string additional_progression_requirements_restrictions { get; set; }
            public List<StudyLevel> study_level { get; set; }
            public AscedDetailed asced_detailed { get; set; }
            public List<object> accrediting_bodies { get; set; }
            public AscedBroad asced_broad { get; set; }
            public OwningOrg owning_org { get; set; }
            public PublishedInHandbook published_in_handbook { get; set; }
            public List<object> collaborating_disciplines { get; set; }
            public string duration_ft_min { get; set; }
            public AcademicOrg academic_org { get; set; }
            public string end_date { get; set; }
            public string structure_summary { get; set; }
            public ParentAcademicOrg parent_academic_org { get; set; }
            public InternationalAvailabilityClarification international_availability_clarification { get; set; }
            public string credit_points { get; set; }
            public string duration_ft_max { get; set; }
            public string duration_pt_std { get; set; }
            public List<object> special_admission_requirements { get; set; }
            public DurationPtPeriod duration_pt_period { get; set; }
            public Location location { get; set; }
            public string callista_version { get; set; }
            public Subclass subclass { get; set; }
            public EnrolmentRestrictions enrolment_restrictions { get; set; }
            public string cl_code { get; set; }
            public List<IntakePeriod> intake_period { get; set; }
            public string cl_id { get; set; }
            public AscedNarrow asced_narrow { get; set; }
            public string title { get; set; }
            public string version { get; set; }
            public List<object> delivery_method { get; set; }
            public DurationFtPeriod duration_ft_period { get; set; }
            public string duration_ft_std { get; set; }
            public string duration_pt_min { get; set; }
            public AcademicCalendar academic_calendar { get; set; }
            public string duration_pt_max { get; set; }
            public string abbreviated_name_and_major { get; set; }
            public object professional_accreditation { get; set; }
            public string version_name { get; set; }
            public string duration_full_time { get; set; }
            public string start_date { get; set; }
            public List<object> areas_of_employment { get; set; }
            public string uac_code { get; set; }
            public string abbreviated_name { get; set; }
            public string entry_requirements_onshore { get; set; }
            public Status status { get; set; }
            public object html { get; set; }
            public string value2 { get; set; }
            public string link_url { get; set; }
            public string hbeorder { get; set; }
            public string text { get; set; }
            public Hbetype hbetype { get; set; }
            public string handbook_entry_field_content { get; set; }
            public string heading { get; set; }
            public Category category { get; set; }
            public string value1 { get; set; }
            public string handbook_code { get; set; }
            public object fees_description { get; set; }
            public CourseVersion course_version { get; set; }
            public object progression { get; set; }
            public object articulation_arrangement { get; set; }
            public object special_admission { get; set; }
            public object prior_learning_recognition { get; set; }
            public object research_areas { get; set; }
            public object participation_enrolment { get; set; }
            public string cricos_disclaimer_applicable { get; set; }
            public string full_time_duration { get; set; }
            public object credit_arrangements { get; set; }
            public string internship_placement { get; set; }
            public string cricos_code { get; set; }
            public string career_opportunities { get; set; }
            public string award_titles { get; set; }
            public string additional_info { get; set; }
            public List<object> work_based_training { get; set; }
            public List<object> requisites { get; set; }
            public List<HbAward> hb_awards { get; set; }
            public List<HbHandbookEntry> hb_handbook_entry { get; set; }
            public List<HbCode> hb_codes { get; set; }
            public List<object> articulated_associated_items { get; set; }
            public List<Offering> offering { get; set; }
            public List<object> hb_accreditations { get; set; }
            public List<LearningOutcome> learning_outcomes { get; set; }
            public StudyLevelSingle study_level_single { get; set; }
            public string course_search_title { get; set; }
            public string academic_calendar_tooltip { get; set; }
            public string study_level_tooltip { get; set; }
            public string delivery_mode_single { get; set; }
            public string location_v2 { get; set; }
            public OfferingDetail offering_detail { get; set; }
            public object accrediting_bodies_list { get; set; }
            public List<object> managing_academic_org { get; set; }
            public string award_title_single { get; set; }
            public List<object> managing_faculty { get; set; }
            public List<object> associated_programs { get; set; }
            public List<HbEnrolmentRule> hb_enrolment_rules { get; set; }
            public string search_title { get; set; }
            public string academic_item_type { get; set; }
            public string award_type_heading { get; set; }
            public string award_type_single { get; set; }
            public string course_sample_staticcontent { get; set; }
            public string delivery_method_single { get; set; }
            public string special_admissions_combined { get; set; }
            public List<EntryRequirementsV2> entry_requirements_v2 { get; set; }
            public List<object> related_double_degrees { get; set; }
            public object standalone_programs { get; set; }
            public List<object> pathway_postgraduate { get; set; }
            public List<object> pathway_honours { get; set; }
            public string campus { get; set; }
            public List<object> pathway_articuluation { get; set; }
            public string credit_points_header { get; set; }
            public List<object> related_associated_items { get; set; }
            public string component_parent_academic_orgs { get; set; }
            public string program_structure_heading { get; set; }
            public List<SpecialAdmissionRequirementsV2> special_admission_requirements_v2 { get; set; }
            public List<FacultyDetail> faculty_detail { get; set; }
            public string description { get; set; }
            public string progression_requirements_staticcontent { get; set; }
            public string standalone_programs_intro_staticcontent { get; set; }
            public string code { get; set; }
            public object script_test { get; set; }
            public string aqf_level_single { get; set; }
            public string intake_period_single { get; set; }
            public string type { get; set; }
            public RecognitionOfAchievements recognition_of_achievements { get; set; }
            public string no_enrolment { get; set; }
            public List<object> enrolment_requirements { get; set; }
            public string professional_recognition { get; set; }
            public string uac_code_single { get; set; }
            public string course_code { get; set; }
            public string duration_hb_display { get; set; }
            public string doubledegree_enrolment_disclaimer { get; set; }
            public List<object> links { get; set; }
        }

        internal class CurriculumStructure2
        {
            public string value { get; set; }
            public string cl_id { get; set; }
            public string key { get; set; }
        }

        internal class RelationshipType
        {
            public string label { get; set; }
            public string value { get; set; }
        }

        internal class ClId
        {
            public string value { get; set; }
            public string cl_id { get; set; }
            public string key { get; set; }
        }

        internal class ParentId
        {
            public string value { get; set; }
            public string cl_id { get; set; }
            public string key { get; set; }
            public string type { get; set; }
        }

        internal class Source
        {
            public string value { get; set; }
            public string cl_id { get; set; }
            public string key { get; set; }
        }

        internal class RelatedAcademicItem
        {
            public string value { get; set; }
            public object cl_id { get; set; }
            public string key { get; set; }
        }

        internal class HorizontalGrouping
        {
            public object label { get; set; }
            public object value { get; set; }
        }

        internal class VerticalGrouping
        {
            public string label { get; set; }
            public string value { get; set; }
        }

        internal class ChildRecord
        {
            public string value { get; set; }
            public object cl_id { get; set; }
            public string key { get; set; }
            public object type { get; set; }
        }

        internal class ParentRecord
        {
            public string value { get; set; }
            public string cl_id { get; set; }
            public string key { get; set; }
            public string type { get; set; }
        }

        internal class ParentConnector
        {
            public string label { get; set; }
            public string value { get; set; }
        }

        internal class DynamicRelationship
        {
            public ParentRecord parent_record { get; set; }
            public string parent_table { get; set; }
            public string dynamic_mapping { get; set; }
            public string cl_id { get; set; }
            public string rule { get; set; }
            public string mapping_type { get; set; }
            public string description { get; set; }
            public string order { get; set; }
            public string encodedURL { get; set; }
            public string dynamic_query { get; set; }
            public List<object> links { get; set; }
        }

        internal class Container
        {
            public RelatedAcademicItem related_academic_item { get; set; }
            public HorizontalGrouping horizontal_grouping { get; set; }
            public string preface { get; set; }
            public string dynamic_query { get; set; }
            public string child_table { get; set; }
            public VerticalGrouping vertical_grouping { get; set; }
            public ChildRecord child_record { get; set; }
            public string footnote { get; set; }
            public string credit_points_max { get; set; }
            public string cl_id { get; set; }
            public string set_based { get; set; }
            public string map_type { get; set; }
            public string title { get; set; }
            public string credit_points { get; set; }
            public ParentRecord parent_record { get; set; }
            public string parent_table { get; set; }
            public ParentConnector parent_connector { get; set; }
            public string exclude { get; set; }
            public List<object> related_ai { get; set; }
            public List<object> container { get; set; }
            public string order { get; set; }
            public string description { get; set; }
            public List<object> relationship { get; set; }
            public List<DynamicRelationship> dynamic_relationship { get; set; }
        }

        internal class CurriculumStructure
        {
            public CurriculumStructure2 curriculum_structure { get; set; }
            public RelationshipType relationship_type { get; set; }
            public string ai_to_cs_cl_id { get; set; }
            public ClId cl_id { get; set; }
            public string name { get; set; }
            public string credit_points { get; set; }
            public ParentId parent_id { get; set; }
            public string effective_date { get; set; }
            public string structure_cl_id { get; set; }
            public Source source { get; set; }
            public string parent_table { get; set; }
            public List<Container> container { get; set; }
            public string implementation_year { get; set; }
            public List<object> links { get; set; }
        }

        internal class Contentlet
        {
            public string studyLevelURL { get; set; }
            public string data { get; set; }
            public string keywords { get; set; }
            public string awardTitle { get; set; }
            public string studyLevel { get; set; }
            public string deliveryMethodAlt { get; set; }
            public string inode { get; set; }
            public string urlYear { get; set; }
            public string CurriculumStructure { get; set; }
            public string host { get; set; }
            public bool locked { get; set; }
            public string stInode { get; set; }
            public string contentType { get; set; }
            public string identifier { get; set; }
            public string active { get; set; }
            public string isMultiAward { get; set; }
            public string folder { get; set; }
            public bool hasTitleImage { get; set; }
            public int sortOrder { get; set; }
            public string name { get; set; }
            public string intakePeriods { get; set; }
            public string hostName { get; set; }
            public string modDate { get; set; }
            public string code { get; set; }
            public string deliveryMethod { get; set; }
            public int noEnrolment { get; set; }
            public string description { get; set; }
            public string parentAcademicOrgV1 { get; set; }
            public string title { get; set; }
            public string contentTypeLabel { get; set; }
            public string baseType { get; set; }
            public bool archived { get; set; }
            public bool working { get; set; }
            public bool live { get; set; }
            public string academicOrg { get; set; }
            public string owner { get; set; }
            public string ascedBroad { get; set; }
            public string studyLevelValue { get; set; }
            public int languageId { get; set; }
            public string externalId { get; set; }
            public string URL_MAP_FOR_CONTENT { get; set; }
            public string parentAcademicOrg { get; set; }
            public string url { get; set; }
            public string generic { get; set; }
            public string titleImage { get; set; }
            public string modUserName { get; set; }
            public string implementationYear { get; set; }
            public string urlMap { get; set; }
            public string modUser { get; set; }
        }
    }







}
