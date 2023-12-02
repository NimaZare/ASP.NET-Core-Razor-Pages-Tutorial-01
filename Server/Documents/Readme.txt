*** my notes ***

1)
	Run application and check it

2)
	Resource Philosophy
		Multilingual
			کشورهای عربی
		شناسه کاربر -> شناسه کاربری
		لهجه‌ها

3)
	Culture -> Almost -> Language

	2

		fa	en	fr	ar

	5

		fa-IR	en-US	en-UK	fr-FR

4)
	We should have one and only one master resource!
		It's better master be in english!

		X.resx

	We can have zero or more slave resources!

		X.fa.resx
		X.fa-IR.resx
		X.fr-FR.resx

5)
	Steps

		A. Create a master resource file (X.resx)
		B. Change the access modifier to 'Public'
		C. Add some key value in master resource file
			Name should not have and (.) or spacebar!
		D. Run custom tool
		E. Create a new resource (X.fa.resx)
		F. Copy all key value from master resource file to slave resource file
		G. Never change the access modifier of slave resource files 'No code generation'
		H. Slave resource files should not have designer!
		I. Check the 'Resources.csproj' file

6)
	Shared -> in 'Resources' project -> Create Resource file:

		DataDictionary.resx		(Public)(Run custom tool)
		DataDictionary.fa.resx	(No code generation)

7)
	Use resources in below files:

		Pages ->
			Index
			About
			Contact

8)
	Pages:
		_ViewStart.cshtml

9)
	Pages:
		Shared:
			Layouts:
				Ltr:
					_Layout.cshtml
				Rtl:
					_Layout.cshtml

10)
	wwwroot:
		css:
			ltr:
				site.css
			Rtl:
				site.css

11)
	libman.json

		{
			"library": "flag-icon-css@4.1.5",
			"destination": "wwwroot/lib/flag-icon-css/"
		}

12)
	Pages:
		Shared:
			PartialViews:
				Ltr:
					_Footer.cshtml
					_Header.cshtml
					_Scripts.cshtml
					_StyleSheets.cshtml
				Rtl:
					_Footer.cshtml
					_Header.cshtml
					_Scripts.cshtml
					_StyleSheets.cshtml

13)
	Pages:
		Shared:
			PartialViews:
				_ChangeCulture.cshtml


********* END *********