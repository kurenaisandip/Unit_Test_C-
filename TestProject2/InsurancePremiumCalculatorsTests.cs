using System.Diagnostics;
using InsuranceCalculator;
using Xunit;

namespace TestProject2
{
    public class InsurancePremiumCalculatorsTests
    {

        [Fact]
        public void CalculatePremium_Young_ReturnCorrectPremium()
        {
            // Arrange
            InsurancePremiumCalculator c = new InsurancePremiumCalculator();


            // Act
            decimal premium = c.CalulatePremuim(25, false);


            // Assert
            Assert.Equal(150, premium);
            
        }

        [Fact]
        public void CalculatePremium_Smoker_ReturnCorrectPremium()
        {
            // Arrange
            InsurancePremiumCalculator c = new InsurancePremiumCalculator();
            
            // Act
            decimal premium = c.CalulatePremuim(52, true);
            
            // Assert
            Assert.Equal(350, premium);
        }
        
    }
}