using SignInLib;
namespace TestProject1
{
    [TestClass]
    public class SignInTest
    {
        //SignInLib.SignIn sign=new SignInLib.SignIn();
        [TestMethod]
        public void SuccessMethod1()
        {
            string expresult = "valid user";
            Assert.AreEqual(expresult,SignIn.Authenticate("sam", "sam@1256"));
        }
        [TestMethod]
        public void FailMethod1()
        {
            string expresult = "invalid user credential";
            Assert.AreEqual(expresult, SignIn.Authenticate("ravi", "ravi@123"));
        }
        [TestMethod]
        public void AnonymousMethod()
        {
            string expresult = "you must provide Username and password";
            Assert.AreEqual(expresult, SignIn.Authenticate(null, null));
        }
    }
}