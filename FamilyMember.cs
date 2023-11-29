using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	public class FamilyMember
	{
		public int Age { get; set; }
		public Gender Gender { get; set; }
		public string FullName { get; set; }
		public FamilyMember? Mother { get; set; }
		public FamilyMember? Father { get; set; }
		public FamilyMember[] GetGrandMother()
		{
			return new FamilyMember[] { Mother?.Mother, Father?.Mother };
		}
		public FamilyMember[] GetGrandFather()
		{
			return new FamilyMember[] { Mother?.Father, Father?.Father };
		}
		public FamilyMember? Myj { get; set; }
		public FamilyMember? Jena { get; set; }

		public FamilyMember GetMyVifu()
		{
			return Jena;
		}
		public FamilyMember GetMyHusband()
		{
			return Myj;
		}

	}
}
public enum Gender
{
	male,
	female
}


