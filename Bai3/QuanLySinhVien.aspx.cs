using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class QuanLySinhVien : System.Web.UI.Page
{
    static int selected = -1;
    static String mode = "view";

    protected void Page_Load(object sender, EventArgs e)
    {
        init();
        bindData();
    }

    public void init()
    {
        btnAdd.Enabled = true;
        btnEdit.Enabled = false;
        btnSave.Enabled = false;
        btnCancel.Enabled = false;
        btnRemove.Enabled = false;
        disableForm();
        bindData();
    }

    protected void bindData()
    {
        DataSet ds = new DataSet();
        ds.ReadXml(Server.MapPath("xml/SinhVien.xml"));

        GridView1.DataSource = ds;
        GridView1.DataBind();
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        mode = "selected";
        btnAdd.Enabled = false;
        btnSave.Enabled = false;
        btnCancel.Enabled = true;
        btnEdit.Enabled = true;
        btnRemove.Enabled = true;

        selected = GridView1.SelectedIndex;
        parseData(selected);
    }

    protected void parseData(int index)
    {
        XmlDocument doc = new XmlDocument();
        doc.Load(Server.MapPath("xml/SinhVien.xml"));
        XmlNodeList nodeList = doc.GetElementsByTagName("SinhVien");
        XmlNode sNode = nodeList[index];
        inMSSV.Value = sNode["MSSV"].InnerText;
        inFirstName.Value = sNode["HoSV"].InnerText;
        inLastName.Value = sNode["TenSV"].InnerText;
        inGender.Value = sNode["GioiTinh"].InnerText;
        inBirth.Value = sNode["NgaySinh"].InnerText;
        inAddress.Value = sNode["DiaChi"].InnerText;
        inClass.Value = sNode["MaLop"].InnerText;
        inYear.Value = sNode["NamHoc"].InnerText;
    }

    public void emptyForm()
    {
        inMSSV.Value = "";
        inFirstName.Value = "";
        inLastName.Value = "";
        inGender.Value = "";
        inBirth.Value = "";
        inAddress.Value = "";
        inClass.Value = "";
        inYear.Value = "";
    }

    public void disableForm()
    {
        inMSSV.Disabled = true;
        inFirstName.Disabled = true;
        inLastName.Disabled = true;
        inGender.Disabled = true;
        inBirth.Disabled = true;
        inAddress.Disabled = true;
        inClass.Disabled = true;
        inYear.Disabled = true;
    }

    public void EnableForm()
    {
        inMSSV.Disabled = false;
        inFirstName.Disabled = false;
        inLastName.Disabled = false;
        inGender.Disabled = false;
        inBirth.Disabled = false;
        inAddress.Disabled = false;
        inClass.Disabled = false;
        inYear.Disabled = false;
    }

    protected void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnRemove.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            EnableForm();
            mode = "add";
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        btnAdd.Enabled = false;
        btnEdit.Enabled = false;
        btnSave.Enabled = true;
        btnCancel.Enabled = true;
        btnRemove.Enabled = false;
        EnableForm();
        mode = "edit";
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        if(mode == "add")
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(Server.MapPath("xml/SinhVien.xml"));
            XmlNode node = doc.GetElementsByTagName("SinhVien")[0];
            XmlNode sNode = (XmlNode)node.CloneNode(true);
            sNode["MSSV"].InnerText = inMSSV.Value;
            sNode["HoSV"].InnerText = inFirstName.Value;
            sNode["TenSV"].InnerText = inLastName.Value;
            sNode["GioiTinh"].InnerText = inGender.Value;
            sNode["NgaySinh"].InnerText = inBirth.Value;
            sNode["DiaChi"].InnerText = inAddress.Value;
            sNode["MaLop"].InnerText = inClass.Value;
            sNode["NamHoc"].InnerText = inYear.Value;

            doc.SelectSingleNode("DSSinhVien").AppendChild(sNode);
            doc.Save(Server.MapPath("xml/SinhVien.xml"));
        }

        if(mode == "edit")
        {
            int index = selected;

            XmlDocument doc = new XmlDocument();
            doc.Load(Server.MapPath("xml/SinhVien.xml"));
            XmlNodeList nodeList = doc.GetElementsByTagName("SinhVien");
            XmlNode sNode = nodeList[index];
            sNode["MSSV"].InnerText = inMSSV.Value;
            sNode["HoSV"].InnerText = inFirstName.Value;
            sNode["TenSV"].InnerText = inLastName.Value;
            sNode["GioiTinh"].InnerText = inGender.Value;
            sNode["NgaySinh"].InnerText = inBirth.Value;
            sNode["DiaChi"].InnerText = inAddress.Value;
            sNode["MaLop"].InnerText = inClass.Value;
            sNode["NamHoc"].InnerText = inYear.Value;
            doc.Save(Server.MapPath("xml/SinhVien.xml"));
        }
        
        bindData();
        emptyForm();
        init();
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        emptyForm();
        init();
    }

    protected void btnRemove_Click(object sender, EventArgs e)
    {
        int index = selected;

        XmlDocument doc = new XmlDocument();
        doc.Load(Server.MapPath("xml/SinhVien.xml"));
        XmlNode root = doc.SelectSingleNode("DSSinhVien");
        root.RemoveChild(doc.GetElementsByTagName("SinhVien")[index]);
        doc.Save(Server.MapPath("xml/SinhVien.xml"));
        selected = -1;
        emptyForm();

        bindData();
        init();
    }
}