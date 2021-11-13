<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
	<xsl:template match="/">
		<html>
			<body>
				<h2>Students</h2>
				<table boarder ="1">
					<tr bgcolor="#99ffcc">
						<th style="text-align:left">FullName</th>
						<th style="text-align:left">Faculty</th>
						<th style="text-align:left">Speciality</th>
						<th style="text-align:left">Cathedra</th>
						<th style="text-align:left">Subjects</th>
						<th style="text-align:left">RateMark</th>
					</tr>
					<xsl:for-each select="Students/Student">
						<xsl:sort select="RateMark" order="descending"/>
						<tr>
							<td>
								<xsl:value-of select="FullName"/>
							</td>
							<td>
								<xsl:value-of select="Faculty"/>
							</td>
							<td>
								<xsl:value-of select="Speciality"/>
							</td>
							<td>
								<xsl:value-of select="Cathedra"/>
							</td><td>
								<xsl:value-of select="Subjects"/>
							</td><td>
								<xsl:value-of select="RateMark"/>
							</td>
						</tr>
					</xsl:for-each>
				</table>	
			</body>
		</html>	
	</xsl:template>
</xsl:stylesheet>