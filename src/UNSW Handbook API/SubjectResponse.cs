using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNSW_Handbook_API
{


    internal class SubjectResponse
    {
        public List<Contentlet> contentlets { get; set; }

        internal class PublishedInHandbook
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
        internal class StudyLevel
        {
            public string label { get; set; }
            public string value { get; set; }
        }

        internal class Status
        {
            public string label { get; set; }
            public string value { get; set; }
        }

        internal class ParentId
        {
            public string value { get; set; }
            public string cl_id { get; set; }
            public string key { get; set; }
            public string type { get; set; }
        }

        internal class AcademicCalendarType
        {
            public string value { get; set; }
            public string cl_id { get; set; }
            public string key { get; set; }
        }

        internal class AcademicOrg
        {
            public string value { get; set; }
            public string cl_id { get; set; }
            public string key { get; set; }
        }

        internal class DeliveryMethod
        {
            public object label { get; set; }
            public object value { get; set; }
        }

        internal class DurationFtPeriod
        {
            public object label { get; set; }
            public object value { get; set; }
        }

        internal class AscedNarrow
        {
            public string value { get; set; }
            public string cl_id { get; set; }
            public string key { get; set; }
        }

        internal class Subclass
        {
            public string label { get; set; }
            public string value { get; set; }
        }

        internal class Type
        {
            public string label { get; set; }
            public string value { get; set; }
        }

        internal class ParentAcademicOrg
        {
            public string value { get; set; }
            public string cl_id { get; set; }
            public string key { get; set; }
        }

        internal class DurationPtPeriod
        {
            public object label { get; set; }
            public object value { get; set; }
        }

        internal class AscedBroad
        {
            public string value { get; set; }
            public string cl_id { get; set; }
            public string key { get; set; }
        }

        internal class AdminLocation
        {
            public string value { get; set; }
            public string cl_id { get; set; }
            public string key { get; set; }
        }

        internal class AcademicItem
        {
            public string value { get; set; }
            public string cl_id { get; set; }
            public string key { get; set; }
        }

        internal class UnitLearningOutcome
        {
            public List<object> lo_domain { get; set; }
            public string order { get; set; }
            public string number { get; set; }
            public string code { get; set; }
            public string lo_cl_id { get; set; }
            public string lo_domain_description { get; set; }
            public List<object> offerings { get; set; }
            public string linking_id { get; set; }
            public AcademicItem academic_item { get; set; }
            public string description { get; set; }
            public string cl_id { get; set; }
            public List<object> ga_map { get; set; }
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

        internal class HbEntry
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

        internal class Parent
        {
            public string value { get; set; }
            public string cl_id { get; set; }
            public string key { get; set; }
        }

        internal class SchoolDetail
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
        }

        internal class DeliveryCollaborators
        {
            public string label { get; set; }
            public string value { get; set; }
        }

        internal class DeliveryMode
        {
            public string value { get; set; }
            public string cl_id { get; set; }
            public string key { get; set; }
        }

        internal class HbDeliveryVariation
        {
            public DeliveryCollaborators delivery_collaborators { get; set; }
            public DeliveryMode delivery_mode { get; set; }
            public string handbook_notes { get; set; }
            public string delivery_name { get; set; }
            public string contact_hours { get; set; }
            public string delivery_variation_label { get; set; }
            public string cl_id { get; set; }
            public string display_name { get; set; }
        }

        internal class EnrolmentRule
        {
            public string active { get; set; }
            public AcademicItem academic_item { get; set; }
            public Type type { get; set; }
            public string order { get; set; }
            public string cl_id { get; set; }
            public string description { get; set; }
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
        }

        internal class Location
        {
            public string value { get; set; }
            public object cl_id { get; set; }
            public string key { get; set; }
        }

        internal class TeachingPeriod
        {
            public string value { get; set; }
            public string cl_id { get; set; }
            public string key { get; set; }
        }

        internal class AttendanceMode
        {
            public string value { get; set; }
            public object cl_id { get; set; }
            public string key { get; set; }
        }

        internal class UnitOffering
        {
            public string fees_domestic { get; set; }
            public string publish { get; set; }
            public Location location { get; set; }
            public string name { get; set; }
            public string clarification_to_appear_in_handbook { get; set; }
            public string display_name { get; set; }
            public TeachingPeriod teaching_period { get; set; }
            public AttendanceMode attendance_mode { get; set; }
            public string quota_number { get; set; }
            public StudyLevel study_level { get; set; }
            public string self_enrol { get; set; }
            public AcademicItem academic_item { get; set; }
            public string fees_commonwealth { get; set; }
            public string fees_international { get; set; }
            public string course_restrictions { get; set; }
            public string cl_id { get; set; }
        }

        internal class FeesCommonwealthLink
        {
            public string label { get; set; }
            public string value { get; set; }
        }

        internal class FeesDomesticLink
        {
            public string label { get; set; }
            public string value { get; set; }
        }

        internal class FeesInternationalLink
        {
            public string label { get; set; }
            public string value { get; set; }
        }

        internal class Fees
        {
            public FeesCommonwealthLink fees_commonwealth_link { get; set; }
            public string fees_commonwealth { get; set; }
            public FeesDomesticLink fees_domestic_link { get; set; }
            public string fees_domestic { get; set; }
            public FeesInternationalLink fees_international_link { get; set; }
            public string fees_international { get; set; }
        }

        internal class Campus
        {
            public string name { get; set; }
        }

        internal class OfferingDetail
        {
            public string key { get; set; }
            public Fees fees { get; set; }
            public string offering_terms { get; set; }
            public string fees_table { get; set; }
            public List<object> erg { get; set; }
            public Campus campus { get; set; }
        }

        internal class StudyLevelSingle
        {
            public string label { get; set; }
            public string value { get; set; }
        }

        internal class Attribute
        {
            public string name { get; set; }
            public string code { get; set; }
            public string description { get; set; }
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

        internal class Exclusion
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
            public object assoc_campus { get; set; }
            public string assoc_url { get; set; }
            public string assoc_class { get; set; }
            public object assoc_award_titles { get; set; }
            public string assoc_state { get; set; }
            public string assoc_award_single { get; set; }
            public string assoc_code { get; set; }
            public string assoc_class_translated_subjects { get; set; }
            public string assoc_faculty { get; set; }
            public string assoc_class_translated { get; set; }
            public string assoc_duration_hb_display { get; set; }
            public AssocCurrentVersion assoc_current_version { get; set; }
            public List<object> links { get; set; }
        }

        internal class DeliveryVariation
        {
            public string cl_id { get; set; }
            public string name { get; set; }
        }

        internal class Individual
        {
            public object label { get; set; }
            public object value { get; set; }
        }

        internal class AssessmentType
        {
            public string label { get; set; }
            public string value { get; set; }
        }

        internal class LearningOutcome
        {
            public string value { get; set; }
            public string cl_id { get; set; }
            public string key { get; set; }
        }

        internal class Assessment
        {
            public Individual individual { get; set; }
            public string assessment_name { get; set; }
            public AssessmentType assessment_type { get; set; }
            public string assessment_id { get; set; }
            public string weighting { get; set; }
            public string description { get; set; }
            public List<LearningOutcome> learning_outcomes { get; set; }
            public List<object> delivery_variations { get; set; }
            public string applies_to_all_delivery_variations { get; set; }
            public string cl_id { get; set; }
            public List<object> links { get; set; }
        }

        internal class HbAssessment
        {
            public DeliveryVariation delivery_variation { get; set; }
            public List<Assessment> assessments { get; set; }
        }

        internal class Data
        {
            public PublishedInHandbook published_in_handbook { get; set; }
            public string implementation_year { get; set; }
            public string duration_ft_max { get; set; }
            public AscedDetailed asced_detailed { get; set; }
            public List<StudyLevel> study_level { get; set; }
            public Status status { get; set; }
            public string duration_pt_max { get; set; }
            public string duration_pt_std { get; set; }
            public string credit_points { get; set; }
            public ParentId parent_id { get; set; }
            public string start_date { get; set; }
            public string active { get; set; }
            public string cl_code { get; set; }
            public AcademicCalendarType academic_calendar_type { get; set; }
            public AcademicOrg academic_org { get; set; }
            public string sms_version { get; set; }
            public string uac_code { get; set; }
            public string keywords { get; set; }
            public string duration_pt_min { get; set; }
            public string title { get; set; }
            public string effective_date { get; set; }
            public DeliveryMethod delivery_method { get; set; }
            public string duration_ft_std { get; set; }
            public string version { get; set; }
            public string duration_ft_min { get; set; }
            public DurationFtPeriod duration_ft_period { get; set; }
            public AscedNarrow asced_narrow { get; set; }
            public Subclass subclass { get; set; }
            public Type type { get; set; }
            public string version_name { get; set; }
            public string pre_requisites { get; set; }
            public string cl_id { get; set; }
            public ParentAcademicOrg parent_academic_org { get; set; }
            public object content { get; set; }
            public List<object> collaborating_disciplines { get; set; }
            public string overview { get; set; }
            public string end_date { get; set; }
            public DurationPtPeriod duration_pt_period { get; set; }
            public string contact_hours { get; set; }
            public AscedBroad asced_broad { get; set; }
            public AdminLocation admin_location { get; set; }
            public List<UnitLearningOutcome> unit_learning_outcomes { get; set; }
            public List<HbEntry> hb_entries { get; set; }
            public List<SchoolDetail> school_detail { get; set; }
            public List<HbDeliveryVariation> hb_delivery_variations { get; set; }
            public List<EnrolmentRule> enrolment_rules { get; set; }
            public List<FacultyDetail> faculty_detail { get; set; }
            public List<object> requisites { get; set; }
            public List<UnitOffering> unit_offering { get; set; }
            public string academic_calendar_tooltip { get; set; }
            public string academic_item_type { get; set; }
            public string no_enrolment { get; set; }
            public OfferingDetail offering_detail { get; set; }
            public string additional_information { get; set; }
            public string study_level_tooltip { get; set; }
            public string campus { get; set; }
            public StudyLevelSingle study_level_single { get; set; }
            public string code { get; set; }
            public List<Attribute> attributes { get; set; }
            public string credit_points_header { get; set; }
            public List<object> eqivalents { get; set; }
            public List<Exclusion> exclusion { get; set; }
            public string search_title { get; set; }
            public string description { get; set; }
            public List<HbAssessment> hb_assessments { get; set; }
            public object inactive_course_alert { get; set; }
            public string timetableURL { get; set; }
            public string subject_sample_text_staticcontent { get; set; }
            public List<object> links { get; set; }
        }

        internal class Contentlet
        {
            public string studyLevelURL { get; set; }
            public string creditPoints { get; set; }
            public string data { get; set; }
            public string keywords { get; set; }
            public string studyLevel { get; set; }
            public string deliveryMethodAlt { get; set; }
            public string inode { get; set; }
            public string ascedDetailed { get; set; }
            public string host { get; set; }
            public string ascedBroadSingle { get; set; }
            public bool locked { get; set; }
            public string stInode { get; set; }
            public string contentType { get; set; }
            public string identifier { get; set; }
            public string level { get; set; }
            public string active { get; set; }
            public string version { get; set; }
            public string folder { get; set; }
            public bool hasTitleImage { get; set; }
            public int sortOrder { get; set; }
            public string generalEducation { get; set; }
            public string status { get; set; }
            public string hostName { get; set; }
            public string csTags { get; set; }
            public string modDate { get; set; }
            public string code { get; set; }
            public string ascedNarrow { get; set; }
            public string sysId { get; set; }
            public string deliveryMethod { get; set; }
            public int noEnrolment { get; set; }
            public string description { get; set; }
            public string title { get; set; }
            public string contentTypeLabel { get; set; }
            public string baseType { get; set; }
            public bool archived { get; set; }
            public string levelNumber { get; set; }
            public bool working { get; set; }
            public bool live { get; set; }
            public string academicOrg { get; set; }
            public string owner { get; set; }
            public string ascedBroad { get; set; }
            public string studyLevelValue { get; set; }
            public int languageId { get; set; }
            public string URL_MAP_FOR_CONTENT { get; set; }
            public string teachingPeriod { get; set; }
            public string parentAcademicOrg { get; set; }
            public string url { get; set; }
            public string educationalArea { get; set; }
            public string titleImage { get; set; }
            public string modUserName { get; set; }
            public string implementationYear { get; set; }
            public string urlMap { get; set; }
            public int publishedInHandbook { get; set; }
            public string modUser { get; set; }
            public string effectiveDate { get; set; }
        }
    }
}
