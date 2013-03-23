<?xml version="1.0"?>

<xsl:stylesheet version="1.0"
xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

<xsl:template match="/">
  <html>
  <body>
    <h2>Vehicle Inventory</h2>
    <table border="1">
      <tr bgcolor="#9acd32">
        <th>Make</th>
        <th>Model</th>
        <th>Year</th>
        <th>Price</th>
      </tr>
      <xsl:for-each select="Vehicles/Vehicle">
        <tr>
          <td><xsl:value-of select="Make"/></td>
          <td><xsl:value-of select="Model"/></td>
          <td><xsl:value-of select="Year"/></td>
          <td><xsl:value-of select="Price"/></td>
        </tr>
      </xsl:for-each>
    </table>
  </body>
  </html>
</xsl:template>

</xsl:stylesheet>