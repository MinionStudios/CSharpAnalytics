﻿using CSharpAnalytics.Activities;
#if WINDOWS_STORE
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
#else
using Microsoft.VisualStudio.TestTools.UnitTesting;
#endif

namespace CSharpAnalytics.Test.Activities
{
    [TestClass]
    public class EventActivityTests
    {
        [TestMethod]
        public void EventActivity_Constructor_With_Minimal_Parameters_Sets_Correct_Properties()
        {
            var activity = new EventActivity("action", "category");

            Assert.AreEqual("category", activity.Category);
            Assert.AreEqual("action", activity.Action);

            Assert.IsNull(activity.Label);
            Assert.IsNull(activity.Value);
            Assert.IsFalse(activity.NonInteraction);
        }

        [TestMethod]
        public void EventActivity_Constructor_With_All_Parameters_Sets_Correct_Properties()
        {
            var activity = new EventActivity("action", "category", label: "label", value: 5, nonInteraction: true);

            Assert.AreEqual("category", activity.Category);
            Assert.AreEqual("action", activity.Action);
            Assert.AreEqual("label", activity.Label);
            Assert.AreEqual(5, activity.Value);
            Assert.IsTrue(activity.NonInteraction);
        }
    }
}