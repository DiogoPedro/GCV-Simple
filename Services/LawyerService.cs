using CGV_Simple.Models;
using System.Collections.Generic;

namespace CGV_Simple.Services
{
	public class LawyerService
	{
		private List<Lawyer> lawyerList;

		public LawyerService()
		{
			lawyerList = new List<Lawyer>();
		}

		public Lawyer GetLawyerById(string id)
		{
			var user = lawyerList.Find(l => l.Id == id);

			if (user == null)
			{
				throw new Exception("User does not exist");
			}

			return user;
		}

		public List<Lawyer> GetAllUsers()
		{
			return lawyerList.ToList();
		}

		public void AddLawyer(Lawyer user)
		{
			lawyerList.Add(user);
		}

		public void UpdateLawyer(Lawyer user)
		{
			var index = lawyerList.FindIndex(l => l.Id == user.Id);

			if (index != -1)
			{
				lawyerList[index] = user;
			}
			else
			{
				throw new Exception("User does not exist");
			}
		}

		public void DeleteLawyerById(string id)
		{
			var user = GetLawyerById(id);

			if (user != null)
			{
				lawyerList.Remove(user);
			}
		}
	}
}
