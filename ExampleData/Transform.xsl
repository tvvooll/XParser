<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output method="html"></xsl:output>

  <xsl:template match="/">
    <html>
      <head>
        <style>
          td
          {
            border: 0;
            background: #a42550;
            font-family: sans-serif;
            padding: 20px;
            text-align: center;
          }
        </style>
      </head>
      <body>
        <table>
          <TR>
            <th>Прізвище</th>
            <th>Ім'я</th>
            <th>По-батькові</th>
            <th>Факультет</th>
            <th>Кафедра</th>
            <th>Тема</th>
            <th>Дата</th>
          </TR>
          <xsl:for-each select= "Publications/Publication">
            <tr>
              <td>
                <xsl:value-of select="./LastName"/>
              </td>
              <td>
                <xsl:value-of select="./FirstName"/>
              </td>
              <td>
                <xsl:value-of select="./MiddleName"/>
              </td>
              <td>
                <xsl:value-of select="./Faculty"/>
              </td>
              <td>
                <xsl:value-of select="./Cathedra"/>
              </td>
              <td>
                <xsl:value-of select="./Topic"/>
              </td>
              <td>
                <xsl:value-of select="./Date"/>
              </td>
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>
