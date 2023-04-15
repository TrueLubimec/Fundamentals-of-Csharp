using System;
using System.Collections.Generic;
using System.Linq;

namespace Clones;

public class CloneVersionSystem : ICloneVersionSystem
{
	public string Execute(string query)
	{
        List<string> listOfComm = new List<string>();
		Dictionary<string, int> ed = new Dictionary<string, int>(); 

        query = query.Trim();
		string[] SplitQuery = query.Split();
		
		string comm = SplitQuery[0];
		
		int indexOfClone = Int32.Parse(SplitQuery[1]);
        
		int indexOfProg;
        if (SplitQuery.Length >= 3)
		{
			indexOfProg = Int32.Parse(SplitQuery[2]);
		}

		switch(comm)
		{
			case "learn":

			default:
				break;
			}
        return null;
	}

}