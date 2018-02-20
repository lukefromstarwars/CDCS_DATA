<?xml version="1.0" encoding="utf-8"?>

<xsl:stylesheet version="1.0"
                xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:strip-space elements="*" />
  <xsl:output method="xml" indent="yes" />

  <xsl:template match="@*|node()">
    <xsl:copy>
      <xsl:apply-templates select="@*|node()" />
    </xsl:copy>
  </xsl:template>

  <xsl:template match="//value">
    <xsl:element name="{@i18n}">
      <xsl:apply-templates select="node()" />
    </xsl:element>
  </xsl:template>

  <xsl:template match="//zoneActionWerkgebiedList/zoneActionWerkgebied">
    <!--    <xsl:copy>-->
    <ActionZone>
      <xsl:apply-templates select="@*|node()[not(self::parent)]" />
      <parents>
        <xsl:apply-templates select="parent" />
      </parents>
      <parentIds>
        <xsl:for-each select="parent">
          <xsl:value-of select="." />
          <xsl:if test="position() != last()">,</xsl:if>
        </xsl:for-each>
      </parentIds>
    </ActionZone>
    <!--    </xsl:copy>-->
  </xsl:template>
  <xsl:template match="//zoneActionWerkgebiedList">
    <!--    <xsl:copy>-->
    <ActionZones>
      <xsl:apply-templates select="@* | node()"/>
    </ActionZones>
    <!--    </xsl:copy>-->
  </xsl:template>

</xsl:stylesheet>