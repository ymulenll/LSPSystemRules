using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using System.Collections.Generic;
using Interfaces;
using Implementations;

namespace Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestCovariance()
        {
            Entity entity = new User();

            IEnumerable<Entity> entityList = new List<User>();
            
            IRead<Entity> reader = new GenericReader<User>();

            #region other examples
            // Delegates are also covariant.
            Func<Entity> function = () => new User();

            // Arrays are also covariant.
            Entity[] entities = new User[5];
            #endregion
        }

        [TestMethod]
        public void TestContravariance()
        {
            ISave<User> saver = new GenericSaver<Entity>();

            ISave<User> userSaver = new EntitySaver();

            var user = new User();

            saver.Save(user);

            #region contravariance delegates            
            Action<Entity> entityAction = entity => entity.Name = "123";

            Action<User> userAction = entityAction;            
            #endregion
        }

        [TestMethod]
        public void TestInvariance()
        {
            // IReadSave

            // Dictionary is invariant
            // Attempt covariance...
            //IDictionary<Entity, Entity> supertypeDictionary = new Dictionary<User, User>();

            // Attempt contravariance...
            //IDictionary<User, User> subtypeDictionary = new Dictionary<Entity, Entity>();
        }
    }
}
