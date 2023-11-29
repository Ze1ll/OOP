using OOP;
public class Program
{
	public static void Main( )
	{
		FamilyMember GrantFatherOne = new FamilyMember()
		{
			FullName = "Oleg Olegovich Olegov",
			Age = 17,
			Gender = Gender.male

		};
		FamilyMember GrantFatherSecond = new FamilyMember()
		{
			FullName = "Ivan Ivanovich Ivanov",
			Age = 16,
			Gender = Gender.male

		};
		FamilyMember GrantMotherOne = new FamilyMember()
		{
			FullName = "Ianna Petrova Olegova",
			Age = 47,
			Gender = Gender.female

		};
		FamilyMember GrantMotherSecond = new FamilyMember()
		{
			FullName = "Oksana Timurovna Ivanova",
			Age = 35,
			Gender = Gender.female

		};
		FamilyMember Father = new FamilyMember()
		{
			FullName = "Batya",
			Age = 35,
			Gender = Gender.male,
			Mother = GrantMotherOne,
			Father = GrantFatherOne,
			
		};
		
		FamilyMember? Mother = new FamilyMember()
		{
			FullName = "Mama",
			Age = 35,
			Gender = Gender.female,
			Mother = GrantMotherSecond,
			Father = GrantFatherSecond,
			Myj = Father

		};
		FamilyMember Son = new FamilyMember()
		{
			FullName = "Oleg",
			Age = 35,
			Gender = Gender.male,
			Mother = Mother,
			Father = Father,

		};
		Father.Jena = Mother;

		/*
		var GrandMothers = Son.GetGrandMother();
		
		var GrandFather = Son.GetGrandFather();

		Console.WriteLine(GrandMothers[0]?.FullName);
		Console.WriteLine(GrandMothers[1]?.FullName);
		*/
		var GetMyj = Mother.GetMyHusband();
		var GetJena = Father.GetMyVifu();
		Console.WriteLine(GetJena.FullName);
		Console.WriteLine(GetMyj.FullName);
	}
}

