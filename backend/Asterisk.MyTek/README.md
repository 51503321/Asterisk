dotnet ef migrations add AddNewTable -p Asterisk.MyTek -s Asterisk.MyTek
dotnet ef database update -p Asterisk.MyTek -s Asterisk.MyTek
dotnet ef migrations remove -p Asterisk.MyTek -s Asterisk.MyTek