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
            
            IRead<Entity> reader = new GenericReader<Entity>();
            //IRead<Entity> reader = new GenericReader<User>();

            //IRead<Entity> methodReader = GetReader();

            Entity e = reader.ReadOne(5);

            #region other examples
            // Delegates are also covariant.
            Func <Entity> function = () => new User();

            // Arrays are also covariant.
            Entity[] entities = new User[5];
            #endregion
        }

        //public static IRead<Entity> GetReader()
        //{
        //    return new GenericReader<User>();
        //}

        [TestMethod]
        public void TestContravariance()
        {
            ISave<Entity> saver = new GenericSaver<Entity>();
            //ISave<User> saver = new GenericSaver<Entity>();

            //ISave<User> userSaver = new EntitySaver();

            //saver.Save(new User());

            #region contravariance delegates            
            Action<Entity> entityAction = entity => entity.Name = "123";

            Action<User> userAction = entityAction;

            userAction(new User());

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
