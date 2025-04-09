using Xunit;
using Utils;

public class LoginTests : BaseTest
{ 
    [Theory]
    [MemberData(nameof(LoginData))]
    public void LoginTestCaseRunner(string email, string password, string alert)
    {
        //if (!string.IsNullOrEmpty(alert))
        //{
        //    homePage
        //        .NavigateToHomepage()
        //        .NavigateToLoginPage()
        //        .PerformLogin(email, password)
        //        .VerifyLoginError(alert);
        //}
        //else
        //{
        //    homePage
        //        .NavigateToHomepage()
        //        .NavigateToLoginPage()
        //        .PerformLogin(email, password)
        //        .VerifyProfilePage()
        //        .PerformLogout();
        //}
    }

    public static IEnumerable<object[]> LoginData()
    {
        string path = Path.Combine(Directory.GetCurrentDirectory(), "../../../src/tests/resources/testdata", "LoginData.xlsx");
        XLReader reader = new XLReader(path, "Sheet1");

        int rowCount = reader.GetRowCount();
        int colCount = reader.GetCellCount(1);

        for (int i = 1; i <= rowCount; i++)
        {
            string email = reader.GetCellData(path, "Sheet1", i, 0);
            string password = reader.GetCellData(path, "Sheet1", i, 1);
            string alert = reader.GetCellData(path, "Sheet1", i, 2);

            yield return new object[] { email, password, alert };
        }
    }
}
