using System;
using System.Collections.Generic;
using System.Text;

namespace NationalArchive.Models
{
    [Serializable()]
    public class InformationAssetViewModel
        {
            public Accessregulation AccessRegulation { get; set; }
            public string Accruals { get; set; }
            public string AccumulationDates { get; set; }
            public string AdministrativeBackground { get; set; }
            public string AppraisalInformation { get; set; }
            public string Arrangement { get; set; }
            public string BatchId { get; set; }
            public EntityReferenceViewModel[] CopiesInformation { get; set; }
            public EntityReferenceViewModel[] CorporateNames { get; set; }
            public EntityReferenceViewModel[] CreatorName { get; set; }
            public string CustodialHistory { get; set; }
            public EntityReferenceViewModel[] DetailedRelatedMaterial { get; set; }
            public EntityReferenceViewModel[] DetailedSeparatedMaterial { get; set; }
            public string Dimensions { get; set; }
            public string FormerReferenceDep { get; set; }
            public string FormerReferencePro { get; set; }
            public EntityReferenceViewModel[] ImmediateSourceOfAcquisition { get; set; }
            public string Language { get; set; }
            public string LegalStatus { get; set; }
            public XReferenceViewModel[] Links { get; set; }
            public EntityReferenceViewModel[] LocationOfOriginals { get; set; }
            public string MapDesignation { get; set; }
            public int MapScaleNumber { get; set; }
            public string Note { get; set; }
            public ReferenceType[] OtherReferences { get; set; }
            public EntityReferenceViewModel[] People { get; set; }
            public string PhysicalCondition { get; set; }
            public string PhysicalDescriptionExtent { get; set; }
            public string PhysicalDescriptionForm { get; set; }
            public PlaceViewModel[] Places { get; set; }
            public string[] PublicationNote { get; set; }
            public string RegistryUrl { get; set; }
            public string RestrictionsOnUse { get; set; }
            public XReferenceViewModel[] ScannedLists { get; set; }
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
            public ScopeContentViewModel ScopeContent { get; set; }
            public bool Digitised { get; set; }
            public XReferenceViewModel[] HeldBy { get; set; }
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
}

