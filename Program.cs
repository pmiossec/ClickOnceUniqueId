using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickOnceUniqueId
{
	class Program
	{
		private static DateTime RefDate = new DateTime(2014, 12, 15);
		static void Main(string[] args)
		{
			var uniqueId = (int)(DateTime.Now - RefDate).TotalSeconds;
			if(args.Length == 0)
				Console.Write(uniqueId);
			else
				UpdateProjectFile(args.First(), uniqueId);
		}


		private static void UpdateProjectFile(string projectFilePath, int? newValue)
		{
			var project = new Microsoft.Build.Evaluation.Project(projectFilePath);

			var property = project.GetProperty("ApplicationRevision");
			if(newValue.HasValue)
				property.UnevaluatedValue = newValue.Value.ToString();
			else
				property.UnevaluatedValue = (System.Int32.Parse(property.EvaluatedValue) + 1).ToString();
			project.Save();

		}
	}
}
