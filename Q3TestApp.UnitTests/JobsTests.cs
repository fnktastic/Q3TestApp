using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Q3TestApp.Application.RxRoomTypes.Commands.MarkJobAsCompleted;
using Q3TestApp.Domain.Entities;
using Q3TestApp.Infrastructure.Persistance;
using Q3TestApp.WebApi.Controllers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Q3TestApp.UnitTests
{
    [TestClass]
    public class JobsTests
    {
        [TestMethod]
        public void MarkJobAsCompleted()
        {
            string completedStatus = "Complete";

            var jobInProgress = new RxJob()
            {
                Status = "In Progress"
            };

            var jobNotStarted = new RxJob()
            {
                Status = "Not Started"
            };

            jobInProgress.MardAsCompleted();
            jobNotStarted.MardAsCompleted();

            Assert.AreEqual(jobInProgress.Status, completedStatus);
            Assert.AreNotEqual(jobNotStarted.Status, completedStatus);
        }
    }
}
