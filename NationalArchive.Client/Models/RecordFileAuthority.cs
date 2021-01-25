using System;
using System.Collections.Generic;
using System.Text;

namespace NationalArchive.Models
{

    public class RecordFileAuthority
    {
        public Accessregulation AccessRegulation { get; set; }
        public string Accruals { get; set; }
        public string AccumulationDates { get; set; }
        public string AdministrativeBackground { get; set; }
        public string AppraisalInformation { get; set; }
        public string Arrangement { get; set; }
        public string BatchId { get; set; }
        public Copiesinformation[] CopiesInformation { get; set; }
        public Corporatename[] CorporateNames { get; set; }
        public Creatorname[] CreatorName { get; set; }
        public string CustodialHistory { get; set; }
        public Detailedrelatedmaterial[] DetailedRelatedMaterial { get; set; }
        public Detailedseparatedmaterial[] DetailedSeparatedMaterial { get; set; }
        public string Dimensions { get; set; }
        public string FormerReferenceDep { get; set; }
        public string FormerReferencePro { get; set; }
        public Immediatesourceofacquisition[] ImmediateSourceOfAcquisition { get; set; }
        public string Language { get; set; }
        public string LegalStatus { get; set; }
        public Link[] Links { get; set; }
        public Locationoforiginal[] LocationOfOriginals { get; set; }
        public string MapDesignation { get; set; }
        public int MapScaleNumber { get; set; }
        public string Note { get; set; }
        public Otherreference[] OtherReferences { get; set; }
        public Person[] People { get; set; }
        public string PhysicalCondition { get; set; }
        public string PhysicalDescriptionExtent { get; set; }
        public string PhysicalDescriptionForm { get; set; }
        public Place[] Places { get; set; }
        public string[] PublicationNote { get; set; }
        public string RegistryUrl { get; set; }
        public string RestrictionsOnUse { get; set; }
        public Scannedlist[] ScannedLists { get; set; }
        public string[] Subjects { get; set; }
        public string[] UnpublishedFindingAids { get; set; }
        public string AccessConditions { get; set; }
        public int CatalogueId { get; set; }
        public string CitableReference { get; set; }
        public string ClosureCode { get; set; }
        public string ClosureStatus { get; set; }
        public string ClosureType { get; set; }
        public string CoveringDates { get; set; }
        public int CoveringFromDate { get; set; }
        public int CoveringToDate { get; set; }
        public Scopecontent ScopeContent { get; set; }
        public bool Digitised { get; set; }
        public Heldby[] HeldBy { get; set; }
        public string Id { get; set; }
        public bool IsParent { get; set; }
        public int CatalogueLevel { get; set; }
        public string ParentId { get; set; }
        public string RecordOpeningDate { get; set; }
        public string ReferencePart { get; set; }
        public string ReferenceParentId { get; set; }
        public string SortKey { get; set; }
        public string Source { get; set; }
        public string Title { get; set; }
    }

    public class Accessregulation
    {
        public string[] ClosureCriteria { get; set; }
        public int ClosureSetId { get; set; }
        public DateTime SignedDate { get; set; }
        public DateTime ReviewDate { get; set; }
        public DateTime ReconsiderDueInDate { get; set; }
        public string LordChancellorsInstrument { get; set; }
        public string Explanation { get; set; }
        public string ProcatTitleText { get; set; }
    }

    public class Scopecontent
    {
        public string[] PlaceNames { get; set; }
        public string Description { get; set; }
        public string Ephemera { get; set; }
        public string Schema { get; set; }
    }

    public class Copiesinformation
    {
        public string Description { get; set; }
        public int EndDate { get; set; }
        public string FirstName { get; set; }
        public string PreTitle { get; set; }
        public int StartDate { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public string XReferenceId { get; set; }
        public string XReferenceCode { get; set; }
        public string XReferenceName { get; set; }
        public string XReferenceType { get; set; }
        public string XReferenceURL { get; set; }
        public string XReferenceDescription { get; set; }
        public string XReferenceSortWord { get; set; }
    }

    public class Corporatename
    {
        public string Description { get; set; }
        public int EndDate { get; set; }
        public string FirstName { get; set; }
        public string PreTitle { get; set; }
        public int StartDate { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public string XReferenceId { get; set; }
        public string XReferenceCode { get; set; }
        public string XReferenceName { get; set; }
        public string XReferenceType { get; set; }
        public string XReferenceURL { get; set; }
        public string XReferenceDescription { get; set; }
        public string XReferenceSortWord { get; set; }
    }

    public class Creatorname
    {
        public string Description { get; set; }
        public int EndDate { get; set; }
        public string FirstName { get; set; }
        public string PreTitle { get; set; }
        public int StartDate { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public string XReferenceId { get; set; }
        public string XReferenceCode { get; set; }
        public string XReferenceName { get; set; }
        public string XReferenceType { get; set; }
        public string XReferenceURL { get; set; }
        public string XReferenceDescription { get; set; }
        public string XReferenceSortWord { get; set; }
    }

    public class Detailedrelatedmaterial
    {
        public string Description { get; set; }
        public int EndDate { get; set; }
        public string FirstName { get; set; }
        public string PreTitle { get; set; }
        public int StartDate { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public string XReferenceId { get; set; }
        public string XReferenceCode { get; set; }
        public string XReferenceName { get; set; }
        public string XReferenceType { get; set; }
        public string XReferenceURL { get; set; }
        public string XReferenceDescription { get; set; }
        public string XReferenceSortWord { get; set; }
    }

    public class Detailedseparatedmaterial
    {
        public string Description { get; set; }
        public int EndDate { get; set; }
        public string FirstName { get; set; }
        public string PreTitle { get; set; }
        public int StartDate { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public string XReferenceId { get; set; }
        public string XReferenceCode { get; set; }
        public string XReferenceName { get; set; }
        public string XReferenceType { get; set; }
        public string XReferenceURL { get; set; }
        public string XReferenceDescription { get; set; }
        public string XReferenceSortWord { get; set; }
    }

    public class Immediatesourceofacquisition
    {
        public string Description { get; set; }
        public int EndDate { get; set; }
        public string FirstName { get; set; }
        public string PreTitle { get; set; }
        public int StartDate { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public string XReferenceId { get; set; }
        public string XReferenceCode { get; set; }
        public string XReferenceName { get; set; }
        public string XReferenceType { get; set; }
        public string XReferenceURL { get; set; }
        public string XReferenceDescription { get; set; }
        public string XReferenceSortWord { get; set; }
    }

    public class Link
    {
        public string XReferenceId { get; set; }
        public string XReferenceCode { get; set; }
        public string XReferenceName { get; set; }
        public string XReferenceType { get; set; }
        public string XReferenceURL { get; set; }
        public string XReferenceDescription { get; set; }
        public string XReferenceSortWord { get; set; }
    }

    public class Locationoforiginal
    {
        public string Description { get; set; }
        public int EndDate { get; set; }
        public string FirstName { get; set; }
        public string PreTitle { get; set; }
        public int StartDate { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public string XReferenceId { get; set; }
        public string XReferenceCode { get; set; }
        public string XReferenceName { get; set; }
        public string XReferenceType { get; set; }
        public string XReferenceURL { get; set; }
        public string XReferenceDescription { get; set; }
        public string XReferenceSortWord { get; set; }
    }

    public class Otherreference
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }

    public class Person
    {
        public string Description { get; set; }
        public int EndDate { get; set; }
        public string FirstName { get; set; }
        public string PreTitle { get; set; }
        public int StartDate { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public string XReferenceId { get; set; }
        public string XReferenceCode { get; set; }
        public string XReferenceName { get; set; }
        public string XReferenceType { get; set; }
        public string XReferenceURL { get; set; }
        public string XReferenceDescription { get; set; }
        public string XReferenceSortWord { get; set; }
    }

    public class Place
    {
        public string Country { get; set; }
        public int CountryID { get; set; }
        public string County { get; set; }
        public int CountyID { get; set; }
        public string Description { get; set; }
        public string DisplayName { get; set; }
        public int EndDate { get; set; }
        public string Grid { get; set; }
        public string LocationType { get; set; }
        public string NewCounty { get; set; }
        public int NewCountyID { get; set; }
        public string OldCounty { get; set; }
        public int OldCountyID { get; set; }
        public string Parish { get; set; }
        public string PlaceName { get; set; }
        public string Region { get; set; }
        public int RegionID { get; set; }
        public int StartDate { get; set; }
        public string Town { get; set; }
        public int TownID { get; set; }
        public string Validation { get; set; }
    }

    public class Scannedlist
    {
        public string XReferenceId { get; set; }
        public string XReferenceCode { get; set; }
        public string XReferenceName { get; set; }
        public string XReferenceType { get; set; }
        public string XReferenceURL { get; set; }
        public string XReferenceDescription { get; set; }
        public string XReferenceSortWord { get; set; }
    }

    public class Heldby
    {
        public string XReferenceId { get; set; }
        public string XReferenceCode { get; set; }
        public string XReferenceName { get; set; }
        public string XReferenceType { get; set; }
        public string XReferenceURL { get; set; }
        public string XReferenceDescription { get; set; }
        public string XReferenceSortWord { get; set; }
    }

}
