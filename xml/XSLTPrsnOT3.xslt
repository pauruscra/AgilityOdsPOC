<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl" xml:space="default"
>
  <xsl:output method= "xml" indent="yes" omit-xml-declaration="yes" standalone="no"/>
  <xsl:template match="node()">
    <xsl:copy>
      <xsl:apply-templates  select="node()"/>
    </xsl:copy>
  </xsl:template>
  <xsl:template match="comment()"/>
  <xsl:template match="PrsnEmployeeNumber"/>
  <!--<xsl:template match="PrsnEmployeeCode"/>-->
  <xsl:template match="PrsnFullName"/>
  <xsl:template match="PrsnFirstName"/>
  <xsl:template match="PrsnMiddleName"/>
  <xsl:template match="PrsnLastName"/>
  <xsl:template match="PrsnNickName"/>
  <xsl:template match="PrsnGender"/>
  <xsl:template match="PrsnEmailAddress"/>
  <!--<xsl:template match="PrsnEmployeeStatus"/>-->
  <xsl:template match="PrsnEmployeeStatusName"/>
  <xsl:template match="PrsnAddressLine1"/>
  <xsl:template match="PrsnAddressLine2"/>
  <xsl:template match="PrsnWorkPhoneNumber"/>
  <xsl:template match="PrsnWorkPhoneExtension"/>
  <xsl:template match="PrsnSubcontractorFlag"/>
  <xsl:template match="PrsnAdministrativeFlag"/>
  <xsl:template match="PrsnProfessionalFlag"/>
  <xsl:template match="PrsnRetiredPartnerFlag"/>
  <xsl:template match="PrsnPartnerTypeCode"/>
  <xsl:template match="PrsnPartnerTypeName"/>
  <xsl:template match="PrsnPartnerAdminProfFlag"/>
  <xsl:template match="PrsnPartnerOtherFlag"/>
  <!--<xsl:template match="PrsnTier"/>-->
  <xsl:template match="PrsnLineOfBusinessCode"/>
  <xsl:template match="PrsnLineOfBusinessName"/>
  <xsl:template match="PrsnServiceLineCode"/>
  <xsl:template match="PrsnServiceLineName"/>
  <xsl:template match="PrsnLocationCode"/>
  <xsl:template match="PrsnLocationName"/>
  <xsl:template match="PrsnSalaryClassCode"/>
  <xsl:template match="PrsnSalaryClassName"/>
  <xsl:template match="PrsnExemptEmployee"/>
  <xsl:template match="PrsnAdjustedHireDate"/>
  <xsl:template match="PrsnAnniversaryDate"/>
  <xsl:template match="PrsnTerminationDate"/>
  <xsl:template match="PrsnFTEPercentage"/>
  <xsl:template match="PrsnPensionPlan"/>
  <xsl:template match="PrsnRankCode"/>
  <xsl:template match="PrsnRankName"/>
  <xsl:template match="PrsnWorkSchedule"/>
  <xsl:template match="PrsnAnnualHours"/>
  <xsl:template match="PrsnPartnerCategoryCode"/>
  <xsl:template match="PrsnPartnerCategoryName"/>
  <xsl:template match="PrsnJobTitleCode"/>
  <xsl:template match="PrsnJobTitleName"/>
  <xsl:template match="PrsnPrimaryIndustryFocus"/>
  <xsl:template match="PrsnCapitalMarket"/>
  <xsl:template match="PrsnTechnicalSpecializations"/>
  <xsl:template match="PrsnManagingDirectorRolePriority"/>
  <xsl:template match="PrsnPositionRole"/>
  <xsl:template match="PrsnIsTimeAndExpenseAllowed"/>
  <xsl:template match="PrsnCapabilityPrimary"/>
  <xsl:template match="PrsnCapabilitySecondary"/>
  <xsl:template match="PrsnDateModified"/>
  <xsl:template match="PrsnPartnerSeparationTypeCode"/>
  <xsl:template match="PrsnPartnerSeparationTypeName"/>
  <xsl:template match="PrsnPartnerRetirementDate"/>
  <xsl:strip-space elements="*"/>
  <xsl:template match="PersonStage">
  <PartyRelationshipPrsnOT3>
    <xsl:apply-templates  select="node()"/>
  </PartyRelationshipPrsnOT3>
  </xsl:template>
  <xsl:template match="Person">
      <PartyRelationship>
        <PartyRelTypeRelationshipTypeIdCode>PRSN-O3T</PartyRelTypeRelationshipTypeIdCode>
        <xsl:apply-templates  select="node()"/>
     </PartyRelationship>
  </xsl:template>
  <xsl:template match="PrsnEmployeeCode">
    <PartyRelSourcePartyTypeCode>PRSN</PartyRelSourcePartyTypeCode>
    <partyRelSourcePartyIdCode>Prsn<xsl:value-of select="text()"/></partyRelSourcePartyIdCode>
    <xsl:apply-templates  select="following-sibling"/>
    </xsl:template>
  <xsl:template match="PrsnTier">
    <PartyRelTargetPartyTypeCode>O3T</PartyRelTargetPartyTypeCode>
    <PartyRelTargetPartyIdCode>O3T-<xsl:value-of select="text()"/></PartyRelTargetPartyIdCode>
    <xsl:apply-templates  select="following-sibling"/>
  </xsl:template>
  <xsl:template match="PrsnEmployeeStatus">
    <PartyRelIsActive>
    <xsl:choose>
        <xsl:when test="PrsnEmployeeStatus = 'AF' ">Y</xsl:when>
        <xsl:when test="PrsnEmployeeStatus = 'AT' ">Y</xsl:when>
        <xsl:when test="PrsnEmployeeStatus = 'CI' ">Y</xsl:when>
        <xsl:when test="PrsnEmployeeStatus = 'LN' ">Y</xsl:when>
        <xsl:when test="PrsnEmployeeStatus = 'LP' ">Y</xsl:when>
        <xsl:when test="PrsnEmployeeStatus = 'NH' ">Y</xsl:when>
        <xsl:when test="PrsnEmployeeStatus = 'NL' ">Y</xsl:when>
        <xsl:when test="PrsnEmployeeStatus = 'NU' ">Y</xsl:when>
        <xsl:when test="PrsnEmployeeStatus = 'OF' ">Y</xsl:when>
        <xsl:when test="PrsnEmployeeStatus = 'OG' ">Y</xsl:when>
        <xsl:when test="PrsnEmployeeStatus = 'OL' ">Y</xsl:when>
        <xsl:when test="PrsnEmployeeStatus = 'OS' ">Y</xsl:when>
        <xsl:when test="PrsnEmployeeStatus = 'PB' ">Y</xsl:when>
        <xsl:when test="PrsnEmployeeStatus = 'PN' ">Y</xsl:when>
        <xsl:when test="PrsnEmployeeStatus = 'R' ">N</xsl:when>
        <xsl:when test="PrsnEmployeeStatus = 'RM' ">N</xsl:when>
        <xsl:when test="PrsnEmployeeStatus = 'RS' ">N</xsl:when>
        <xsl:when test="PrsnEmployeeStatus = 'RT' ">N</xsl:when>
        <xsl:when test="PrsnEmployeeStatus = 'RX' ">N</xsl:when>
        <xsl:when test="PrsnEmployeeStatus = 'SC' ">Y</xsl:when>
        <xsl:when test="PrsnEmployeeStatus = 'SI' ">Y</xsl:when>
        <xsl:when test="PrsnEmployeeStatus = 'SS' ">Y</xsl:when>
        <xsl:when test="PrsnEmployeeStatus = 'T' ">N</xsl:when>
        <xsl:when test="PrsnEmployeeStatus = 'TD' ">N</xsl:when>
        <xsl:when test="PrsnEmployeeStatus = 'TP' ">N</xsl:when>
        <xsl:otherwise>N</xsl:otherwise>
    </xsl:choose> 
    </PartyRelIsActive>
    <xsl:apply-templates  select="following-sibling"/>
  </xsl:template>
</xsl:stylesheet>
