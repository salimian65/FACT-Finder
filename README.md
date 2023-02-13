# FACT-Finder
As a code reviewer
1.	 I would like to ask My teammate who developed this business that explain me the business. Because it seems the current code always throw two different exceptions, once we call it with correct assigned value, it throws the “Format not allowed” exception. And once we call it with incorrect value, it throws “Unknown format” exception. If the business asked you for these two scenario you throw an exception, why you check three condition “f.ToLower() == "number"” .
2.	The naming has a issue. For example, why you named it “class1”, if I were you, named it “FormatValidator”
3.	If the business wants you to write a format validator, I suggest you write in this way:
Please refer to attached code.
