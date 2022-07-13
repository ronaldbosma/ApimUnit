using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApimUnit.Tests.Policies
{
    [TestClass]
    public class SetVariablePolicyTests
    {
        [TestMethod]
        public void Execute_Should_Add_Variable_If_It_Does_Not_Exist()
        {
            // Arrange
            var policyContext = new PolicyContext();
            var sut = new SetVariablePolicy("MyVar", "MyValue");

            // Act
            sut.Execute(policyContext);

            // Assert
            var expectedVariables = new Dictionary<string, object> { { sut.Name, sut.Value } };
            policyContext.Variables.Should().BeEquivalentTo(expectedVariables);
        }

        [TestMethod]
        public void Execute_Should_Update_Variable_Value_If_It_Exist()
        {
            // Arrange
            var policyContext = new PolicyContext();
            policyContext.SetVariable("MyVar", "FirstValue");

            var sut = new SetVariablePolicy("MyVar", "SecondValue");

            // Act
            sut.Execute(policyContext);

            // Assert
            var expectedVariables = new Dictionary<string, object> { { sut.Name, sut.Value } };
            policyContext.Variables.Should().BeEquivalentTo(expectedVariables);
        }
    }
}
