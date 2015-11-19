﻿namespace TouristSitesSystem.Api.Tests.RouteTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Controllers;

    using MyTested.WebApi;

    [TestClass]
    public class CitiesControllerTests
    {
        [TestMethod]
        public void GetShouldMapCorrectly()
        {
            MyWebApi
                .Routes()
                .ShouldMap("api/Cities")
                .To<CitiesController>(c => c.Get());
        }

        [TestMethod]
        public void GetByIdShouldMapCorrectly()
        {
            MyWebApi
                .Routes()
                .ShouldMap("api/Cities/1")
                .To<CitiesController>(c => c.GetById(1));
        }

        [TestMethod]
        public void SearchByNameShouldMapCorrectly()
        {
            MyWebApi
                .Routes()
                .ShouldMap("api/Cities?name=testName")
                .To<CitiesController>(c => c.Search("testName"));
        }
    }
}