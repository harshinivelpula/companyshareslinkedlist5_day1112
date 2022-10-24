using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace companyshares5
{
    internal class linkedlist
    {
		public static void main(String[] args)
        {
			CompanysharesModel compModel = new CompanysharesModel();

			String pathOfCompanyShares = "C:\\Users\\DELL\\source\\repos\\companyshares5\\companyshares5\\jsconfig1.json";

            File file = new File(pathOfCompanyShares);
            if (file.length() != 0)
			{
				compModel = (CompanysharesModel)JsonUtil.readMapper(pathOfCompanyShares, compModel);
			}
		

		LinkedList<companyshare5> compList = new LinkedList<>();
        compList.addAll(compModel.getCompanyshares());
		Boolean isExit = false;
		Console.WriteLine("Please enter password to access company data");
		if (OOPsUtility.stringScanner().equals("admin")) {
			while (!isExit) {
		   Console.WriteLine("Enter company symbol: ");
		int companySymbol = OOPsUtility.integerScanner();
		int indexOfCompany = 0;
		Boolean isCompanyFound = false;
				for (int i = 0; i<compList.size(); i++) {
					if (companySymbol == compList.GetType(i).getCompany_symbol()) {
						isCompanyFound = true;
						indexOfCompany = i;
						break;
				}
}
if (isCompanyFound)
{

	Console.WriteLine("The company you selected is: " + compList.GetType(indexOfCompany).getCompany_name());
	Console.WriteLine("Company shares: " + compList.GetType(indexOfCompany).getCompany_shares());
	Console.WriteLine("Company share price: " + compList.GetType(indexOfCompany).getCompany_share_price());
	Console.WriteLine("Company Total value: " + compList.GetType(indexOfCompany).getCompany_total_value());
	Console.WriteLine("Welcome please select task: ");
	Console.WriteLine("1. for adding shares\n2. for removing shares\n3. for exit");
	int sharesAmount;
	switch (OOPsUtility.integerScanner())
	{
		case 1:
			Console.WriteLine("Enter number of shares");
			sharesAmount = OOPsUtility.integerScanner();
			compList.GetType(indexOfCompany).setCompany_shares(compList.GetType(indexOfCompany).getCompany_shares() + sharesAmount);
			compList.GetType(indexOfCompany).setCompany_total_value(compList.GetType(indexOfCompany).getCompany_shares()* compList.get(indexOfCompany).getCompany_share_price());
			Console.WriteLine("Data saved!!!");
			Console.WriteLine("Company: " + compList.GetType(indexOfCompany).getCompany_name());
			Console.WriteLine("Company shares: " + compList.GetType(indexOfCompany).getCompany_shares());
			Console.WriteLine("Company share price: " + compList.GetType(indexOfCompany).getCompany_share_price());
			Console.WriteLine("Company Total value: " + compList.GetType(indexOfCompany).getCompany_total_value());

			JsonUtil.readMapper(pathOfCompanyShares, compModel);
			break;
		case 2:
			Console.WriteLine("Enter number of shares to remove");
			sharesAmount = OOPsUtility.integerScanner();
			if (compList.GetType(indexOfCompany).getCompany_shares() > sharesAmount)
			{
				compList.GetType(indexOfCompany).setCompany_shares(compList.GetType(indexOfCompany).getCompany_shares() - sharesAmount);
				compList.GetType(indexOfCompany).setCompany_total_value(compList.GetType(indexOfCompany).getCompany_shares()* compList.get(indexOfCompany).getCompany_share_price());

				Console.WriteLine("Data saved!!!");
				Console.WriteLine("Company: " + compList.GetType(indexOfCompany).getCompany_name());
				Console.WriteLine("Company shares: " + compList.GetType(indexOfCompany).getCompany_shares());
				Console.WriteLine("Company share price: " + compList.GetType(indexOfCompany).getCompany_share_price());
				Console.WriteLine("Company Total value: " + compList.GetType(indexOfCompany).getCompany_total_value());
				JsonUtil.readMapper(pathOfCompanyShares, compModel);
			}
			else
				Console.WriteLine("Company don't have that much shares to remove");

			break;
		case 3:
			isExit = true;
			Console.WriteLine("Thank you for your time");
			break;
		default:
			Console.WriteLine("Invalid Option");
			break;

	}
}
else
	Console.WriteLine("Company not found");
			}

		} else
	Console.WriteLine("Invalid password");

	}

	}

    internal class OOPsUtility
    {
        internal static int integerScanner()
        {
            throw new NotImplementedException();
        }

        internal static object stringScanner()
        {
            throw new NotImplementedException();
        }
    }

    internal class JsonUtil
    {
        internal static CompanysharesModel readMapper(string pathOfCompanyShares, CompanysharesModel compModel)
        {
            throw new NotImplementedException();
        }
    }

    internal class CompanysharesModel
    {
        internal object getCompanyshares()
        {
            throw new NotImplementedException();
        }
    }
}
