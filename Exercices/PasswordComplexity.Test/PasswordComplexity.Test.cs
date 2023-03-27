using System;
using Xunit;

namespace PasswordComplexity.Test
{
    public class TestProgroam
    {
        [Fact]
        public void CheckPassword_EnoughLowerCaseLetters_ShouldReturnTrue()
        {
            PasswordRequirements conditions = new PasswordRequirements(4, 0, 0, 0, true, true);
            string password = "abcd";
            Assert.True(Program.CheckPassword(conditions, password));
        }

        [Fact]
        public void CheckPassword_NotEnoughLowerCaseLetters_ShouldReturnFalse()
        {
            PasswordRequirements conditions = new PasswordRequirements(4, 0, 0, 0, true, true);         
            string password = "acd";
            Assert.False(Program.CheckPassword(conditions, password));
        }

        [Fact]
        public void CheckPassword_EnoughUpperCaseLetters_ShouldReturnTrue()
        {
            PasswordRequirements conditions = new PasswordRequirements(0, 2, 0, 0, true, true);
            string password = "DC";
            Assert.True(Program.CheckPassword(conditions, password));
        }

        [Fact]
        public void CheckPassword_NotEnoughUpperCaseLetters_ShouldReturnFalse()
        {
            PasswordRequirements conditions = new PasswordRequirements(0, 2, 0, 0, true, true);
            string password = "Dc";
            Assert.False(Program.CheckPassword(conditions, password));
        }

        [Fact]
        public void CheckPassword_EnoughUpperDigits_ShouldReturnTrue()
        {
            PasswordRequirements conditions = new PasswordRequirements(0, 0, 2, 0, true, true);
            string password = "DC52";
            Assert.True(Program.CheckPassword(conditions, password));
        }

        [Fact]
        public void CheckPassword_NotEnoughDigits_ShouldReturnFalse()
        {
            PasswordRequirements conditions = new PasswordRequirements(0, 0, 2, 0, true, true);
            string password = "Dc5";
            Assert.False(Program.CheckPassword(conditions, password));
        }

        [Fact]
        public void CheckPassword_EnoughUpperSymbols_ShouldReturnTrue()
        {
            PasswordRequirements conditions = new PasswordRequirements(0, 0, 0, 2, true, true);
            string password = "DC52&*";
            Assert.True(Program.CheckPassword(conditions, password));
        }

        [Fact]
        public void CheckPassword_NotEnoughSymbols_ShouldReturnFalse()
        {
            PasswordRequirements conditions = new PasswordRequirements(0, 0, 0, 2, true, true);
            string password = "Dc52*";
            Assert.False(Program.CheckPassword(conditions, password));
        }

        [Fact]
        public void CheckPassword_AmbiguousCharctersNotAllowdAndNotUsed_ShouldReturnTrue()
        {
            PasswordRequirements conditions = new PasswordRequirements(0, 0, 0, 0, true, false);
            string password = "teSt2";
            Assert.True(Program.CheckPassword(conditions, password));
        }

        [Fact]
        public void CheckPassword_AmbiguousCharctersNotAllowdAndUsed_ShouldReturnFalse()
        {
            PasswordRequirements conditions = new PasswordRequirements(0, 0, 0, 0, true, false);
            string password = "{tesT2*";
            Assert.False(Program.CheckPassword(conditions, password));
        }

        [Fact]
        public void CheckPassword_SimilarCharctersNotAllowdAndNotUsed_ShouldReturnTrue()
        {
            PasswordRequirements conditions = new PasswordRequirements(0, 0, 0, 0, false, true);
            string password = "a2";
            Assert.True(Program.CheckPassword(conditions, password));
        }

        [Fact]
        public void CheckPassword_SimilarCharctersNotAllowdAndUsed_ShouldReturnFalse()
        {
            PasswordRequirements conditions = new PasswordRequirements(0, 0, 0, 0, false, true);
            string password = "{tesT2l1*";
            Assert.False(Program.CheckPassword(conditions, password));
        }

        [Fact]
        public void CheckPassword_ComplexConditionsAreRespected_ShouldReturnTrue()
        {
            PasswordRequirements conditions = new PasswordRequirements(5, 2, 1, 1, true, false);
            string password = "ParolaFoarteGr3a*";
            Assert.True(Program.CheckPassword(conditions, password));
        }

        [Fact]
        public void CheckPassword_ComplexConditionsAreRespected_ShouldReturnFalse()
        {
            PasswordRequirements conditions = new PasswordRequirements(5, 2, 1, 1, true, false);
            string password = "ParolaFoarteGrea*";
            Assert.False(Program.CheckPassword(conditions, password));
        }
    }
}
