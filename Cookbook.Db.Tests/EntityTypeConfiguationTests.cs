using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Cookbook.Db.EntityTypes;
using NUnit.Framework;

namespace Cookbook.Db.Tests {
    [TestFixture]
    public class EntityTypeConfiguationTests {
        private const string EntityTypesNamespaceName = "Cookbook.Db.EntityTypes";
        private const string EntityTypeConfigurationsNamespaceName = "Cookbook.Db.EntityTypeConfigurations";

        public static IEnumerable<TestCaseData> EntityTypes() {
            return GetTypesFromNamespace(EntityTypesNamespaceName).Select(t => new TestCaseData(t.Name));
        }

        [Test, TestCaseSource(nameof(EntityTypes))]
        public void EntityType_HasConfiguration(string entityTypeName) {
            //Arrange
            var configurationTypes = GetTypesFromNamespace(EntityTypeConfigurationsNamespaceName)
                .Select(t => t.Name)
                .ToArray();

            //Assert
            bool failed = true;
            foreach (var configurationType in configurationTypes) {
                if (entityTypeName + "Configuration" == configurationType) {
                    failed = false;
                    break;
                }
            }

            Assert.That(failed, Is.False, $"The type {entityTypeName} does not have a configuration");
        }

        private static IEnumerable<Type> GetTypesFromNamespace(string nspace) {
            return from t in Assembly.GetAssembly(typeof(IDbItem)).GetTypes()
                   where t.IsClass && t.Namespace == nspace
                   select t;
        }
    }
}