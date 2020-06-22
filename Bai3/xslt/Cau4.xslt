<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output method="xml" indent="yes"/>

  <xsl:template match="/">
    <table border="1">
      <tr>
        <th>MSSV</th>
        <th>Họ và Tên</th>
        <th>Ngày sinh</th>
        <th>Giới tính</th>
        <th>Địa chỉ</th>
        <th>Mã lớp</th>
        <th>Năm học</th>
      </tr>
      <xsl:for-each select="DSSinhVien/SinhVien">
        <xsl:if test="NamHoc = '2013-2017'">
          <tr>
            <td>
              <xsl:value-of select="MSSV"/>
            </td>
            <td>
              <xsl:value-of select="HoSV"/>&#160;<xsl:value-of select="TenSV"/>
            </td>
            <td>
              <xsl:value-of select="NgaySinh"/>
            </td>
            <td>
              <xsl:value-of select="GioiTinh"/>
            </td>
            <td>
              <xsl:value-of select="DiaChi"/>
            </td>
            <td>
              <xsl:value-of select="MaLop"/>
            </td>
            <td>
              <xsl:value-of select="NamHoc"/>
            </td>
          </tr>
        </xsl:if>
      </xsl:for-each>
    </table>
  </xsl:template>
</xsl:stylesheet>
