using _120_Muistipeli;
namespace MuistiPeliTesti
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void AsetaKuviot()
        {
            //Arrange
            Form1 form1 = new Form1();
            Peli peli = new Peli();
            //Act
            peli.AsetaKuviot(form1);
            


            //Assert
            Assert.IsTrue(form1.tbpKortit.ColumnCount == 0);
        }
        [TestMethod]
        public void FormLoad()
        {
            //Arrange
            Form1 form1 = new Form1();

            //Act
           
        }
    }
}
