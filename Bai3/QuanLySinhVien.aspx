<%@ Page Language="C#" AutoEventWireup="true" CodeFile="QuanLySinhVien.aspx.cs" Inherits="QuanLySinhVien" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        body {
            display: flex;
            flex-direction: column;
            align-items: center;
            justify-content: center;
        }
        form {
            display: flex;
            flex-direction: column;
            align-items: center;
        }
        .form {
            margin-top: 50px;
            width: 500px;
            display: flex;
            flex-direction: column;
            align-items: center;
            border: 1px solid black;
            padding: 10px 20px;
        }
        .form__group, .form__control {
             width: 100%;
             margin-top: 10px;
             display: flex;
         }
         .form__group label {
             display: inline-block;
             width: 100px;
         }
         .form__group input {
             flex: 1;
         }
         .form__control input {
             flex: 1;
             padding: 5px;
         }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" 
                runat="server"
                HorizontalAlign="Center" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
        </div>
        <div class="form">
            <h1>Thông tin Sinh viên</h1>
            <div class="form__group">
                <label for="inMSSV">MSSV</label>
                <input id="inMSSV" type="text" runat="server" />
            </div>
            <div class="form__group">
                <label for="inFirstName">Họ Sinh viên</label>
                <input id="inFirstName" type="text" runat="server" />
            </div>
            <div class="form__group">
                <label for="inLastName">Tên Sinh viên</label>
                <input id="inLastName" type="text" runat="server" />
            </div>
            <div class="form__group">
                <label for="inBirth">Ngày sinh</label>
                <input id="inBirth" type="text" runat="server" />
            </div>
            <div class="form__group">
                <label for="inGender">Giới tính</label>
                <input id="inGender" type="text" runat="server" />
            </div>
            <div class="form__group">
                <label for="inAddress">Địa chỉ</label>
                <input id="inAddress" type="text" runat="server" />
            </div>
            <div class="form__group">
                <label for="inClass">Mã lớp</label>
                <input id="inClass" type="text" runat="server" />
            </div>
            <div class="form__group">
                <label for="inYear">Năm học</label>
                <input id="inYear" type="text" runat="server" />
            </div>
            <div class="form__control">
                <asp:Button ID="btnAdd" runat="server" Text="Thêm" OnClick="btnAdd_Click"/>
                <asp:Button ID="btnEdit" runat="server" Text="Sửa" OnClick="btnEdit_Click"/>
                <asp:Button ID="btnSave" runat="server" Text="Lưu" OnClick="btnSave_Click"/>
                <asp:Button ID="btnCancel" runat="server" Text="Huỷ" OnClick="btnCancel_Click"/>
                <asp:Button ID="btnRemove" runat="server" Text="Xoá" OnClick="btnRemove_Click" />
            </div>
        </div>
    </form>
</body>
</html>
