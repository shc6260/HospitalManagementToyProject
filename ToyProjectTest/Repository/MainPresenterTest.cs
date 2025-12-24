using NUnit.Framework;
using System;
using System.Collections.Generic;
using ToyProject.Model;
using ToyProject.View;

namespace ToyProjectTest
{
    public class MainPresenterTest
    {        
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        class MockMainView : IMainView
        {
            public event EventHandler<long> PatientSelected;
            public event EventHandler<long> ReceptionRequested;
            public event EventHandler<string> SearchTextChanged;

            public void ClearSearch()
            {
                throw new NotImplementedException();
            }

            public void SetPatientList(IEnumerable<Patient> patients)
            {
                throw new NotImplementedException();
            }

            public void ShowPatientDetail(Patient patient)
            {
                throw new NotImplementedException();
            }

            public void ShowReceptionMessage(Patient patient)
            {
                throw new NotImplementedException();
            }
        }
    }
}