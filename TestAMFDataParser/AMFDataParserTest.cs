﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace TestAMFDataParser
{
    
    
    /// <summary>
    ///This is a test class for AMFDataParserTest and is intended
    ///to contain all AMFDataParserTest Unit Tests
    ///</summary>
    [TestClass()]
    public class AMFDataParserTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for ProcessData
        ///</summary>
        [TestMethod()]
        public void ProcessDataTest01()
        {
            AMFDataParser target = new AMFDataParser(); // TODO: Initialize to an appropriate value
            byte[] pmData = {
                0x00,0x03,0x00,0x00,0x00,0x01,0x00,0x12,0x44,0x61,0x74,0x61,0x48,0x61,0x6e,0x64,
                0x6c,0x65,0x72,0x2e,0x68,0x61,0x6e,0x64,0x6c,0x65,0x00,0x02,0x2f,0x31,0x00,0x00,
                0x02,0xe6,0x0a,0x00,0x00,0x00,0x03,0x02,0x00,0x0b,0x67,0x65,0x74,0x5f,0x6d,0x65,
                0x73,0x73,0x61,0x67,0x65,0x11,0x0a,0x0b,0x01,0x1d,0x73,0x68,0x6f,0x77,0x4d,0x65,
                0x73,0x73,0x61,0x67,0x65,0x42,0x61,0x72,0x06,0x03,0x31,0x1d,0x73,0x68,0x6f,0x77,
                0x43,0x68,0x65,0x63,0x6b,0x49,0x6e,0x42,0x61,0x72,0x06,0x03,0x30,0x1f,0x73,0x68,
                0x6f,0x77,0x41,0x63,0x74,0x69,0x76,0x69,0x74,0x79,0x42,0x61,0x72,0x06,0x06,0x09,
                0x6c,0x61,0x6e,0x67,0x06,0x05,0x74,0x75,0x0f,0x76,0x65,0x72,0x73,0x69,0x6f,0x6e,
                0x06,0x15,0x32,0x30,0x31,0x31,0x31,0x32,0x32,0x30,0x30,0x31,0x1d,0x73,0x68,0x6f,
                0x77,0x47,0x69,0x66,0x74,0x42,0x6f,0x78,0x42,0x61,0x72,0x06,0x06,0x17,0x73,0x68,
                0x6f,0x77,0x52,0x61,0x6e,0x6b,0x42,0x61,0x72,0x06,0x02,0x09,0x68,0x6f,0x73,0x74,
                0x06,0x57,0x68,0x74,0x74,0x70,0x3a,0x2f,0x2f,0x66,0x61,0x72,0x6d,0x2d,0x74,0x72,
                0x2d,0x66,0x62,0x2e,0x73,0x6f,0x63,0x69,0x61,0x6c,0x67,0x61,0x6d,0x65,0x6e,0x65,
                0x74,0x2e,0x63,0x6f,0x6d,0x2f,0x73,0x74,0x61,0x74,0x69,0x63,0x2f,0x17,0x62,0x61,
                0x74,0x63,0x68,0x5f,0x64,0x65,0x6c,0x61,0x79,0x06,0x09,0x34,0x30,0x30,0x30,0x13,
                0x74,0x72,0x61,0x6e,0x73,0x70,0x6f,0x72,0x74,0x06,0x49,0x68,0x74,0x74,0x70,0x3a,
                0x2f,0x2f,0x66,0x61,0x72,0x6d,0x2d,0x74,0x72,0x2d,0x66,0x62,0x2e,0x73,0x6f,0x63,
                0x69,0x61,0x6c,0x67,0x61,0x6d,0x65,0x6e,0x65,0x74,0x2e,0x63,0x6f,0x6d,0x2f,0x1b,
                0x61,0x63,0x68,0x69,0x65,0x76,0x65,0x6d,0x65,0x6e,0x74,0x4f,0x6e,0x06,0x02,0x29,
                0x73,0x68,0x6f,0x77,0x5f,0x6e,0x6f,0x5f,0x61,0x63,0x74,0x69,0x6f,0x6e,0x5f,0x70,
                0x6f,0x70,0x75,0x70,0x06,0x13,0x32,0x34,0x30,0x30,0x30,0x30,0x30,0x30,0x30,0x07,
                0x75,0x69,0x64,0x06,0x13,0x37,0x31,0x35,0x39,0x30,0x36,0x37,0x35,0x36,0x21,0x73,
                0x68,0x6f,0x77,0x4c,0x6f,0x76,0x65,0x50,0x6f,0x69,0x6e,0x74,0x42,0x61,0x72,0x06,
                0x06,0x07,0x6d,0x6f,0x64,0x06,0x11,0x66,0x61,0x63,0x65,0x62,0x6f,0x6f,0x6b,0x17,
                0x73,0x68,0x6f,0x77,0x58,0x6d,0x61,0x73,0x42,0x61,0x72,0x06,0x06,0x21,0x73,0x68,
                0x6f,0x77,0x48,0x61,0x6c,0x6c,0x6f,0x77,0x65,0x65,0x6e,0x42,0x61,0x72,0x06,0x06,
                0x2b,0x73,0x68,0x6f,0x77,0x41,0x63,0x63,0x65,0x70,0x74,0x47,0x69,0x66,0x74,0x73,
                0x42,0x75,0x74,0x74,0x6f,0x6e,0x06,0x06,0x1f,0x73,0x68,0x6f,0x77,0x44,0x72,0x61,
                0x77,0x47,0x69,0x66,0x74,0x42,0x61,0x72,0x06,0x06,0x05,0x69,0x64,0x06,0x2a,0x23,
                0x73,0x68,0x6f,0x77,0x49,0x6e,0x76,0x69,0x74,0x65,0x54,0x61,0x73,0x6b,0x42,0x61,
                0x72,0x06,0x06,0x39,0x66,0x65,0x72,0x74,0x69,0x6c,0x69,0x7a,0x65,0x5f,0x74,0x6f,
                0x5f,0x66,0x72,0x69,0x65,0x6e,0x64,0x5f,0x66,0x65,0x65,0x64,0x5f,0x6d,0x61,0x78,
                0x06,0x03,0x32,0x1f,0x73,0x68,0x6f,0x77,0x45,0x78,0x63,0x68,0x61,0x6e,0x67,0x65,
                0x42,0x61,0x72,0x06,0x06,0x2d,0x73,0x68,0x6f,0x77,0x42,0x75,0x79,0x43,0x61,0x73,
                0x68,0x49,0x74,0x65,0x6d,0x54,0x69,0x6d,0x65,0x6f,0x75,0x74,0x06,0x11,0x38,0x36,
                0x34,0x30,0x30,0x30,0x30,0x30,0x29,0x66,0x65,0x65,0x64,0x5f,0x72,0x65,0x77,0x61,
                0x72,0x64,0x5f,0x66,0x65,0x65,0x64,0x5f,0x6d,0x61,0x78,0x06,0x03,0x36,0x1b,0x6e,
                0x65,0x74,0x77,0x6f,0x72,0x6b,0x5f,0x64,0x65,0x6c,0x61,0x79,0x06,0x0d,0x33,0x30,
                0x30,0x30,0x30,0x30,0x13,0x70,0x6c,0x69,0x6e,0x67,0x61,0x4b,0x65,0x79,0x06,0x15,
                0x31,0x33,0x32,0x39,0x38,0x35,0x32,0x37,0x31,0x30,0x2b,0x73,0x68,0x6f,0x77,0x56,
                0x69,0x70,0x44,0x61,0x69,0x6c,0x79,0x52,0x65,0x77,0x61,0x72,0x64,0x42,0x61,0x72,
                0x06,0x06,0x17,0x66,0x62,0x5f,0x73,0x69,0x67,0x5f,0x75,0x73,0x65,0x72,0x06,0x2a,
                0x1b,0x70,0x6c,0x69,0x6e,0x67,0x61,0x53,0x65,0x73,0x73,0x69,0x6f,0x6e,0x06,0x41,
                0x31,0x62,0x35,0x64,0x36,0x32,0x62,0x31,0x63,0x39,0x31,0x33,0x31,0x62,0x61,0x63,
                0x65,0x39,0x32,0x65,0x64,0x62,0x62,0x33,0x32,0x31,0x64,0x64,0x62,0x31,0x37,0x65,
                0x17,0x73,0x77,0x66,0x5f,0x76,0x65,0x72,0x73,0x69,0x6f,0x6e,0x04,0x4f,0x0f,0x63,
                0x61,0x6c,0x6c,0x5f,0x69,0x64,0x06,0x23,0x63,0x61,0x6c,0x6c,0x31,0x33,0x32,0x39,
                0x38,0x35,0x32,0x37,0x37,0x31,0x33,0x32,0x38,0x01,0x02,0x00,0x0b,0x67,0x65,0x74,
                0x5f,0x6d,0x65,0x73,0x73,0x61,0x67,0x65
            };
            bool ret = target.ProcessData(pmData);

            Assert.IsTrue(ret);
        }


        [TestMethod()]
        public void ProcessDataTest02()
        {
            AMFDataParser target = new AMFDataParser(); // TODO: Initialize to an appropriate value
            byte[] pmData = {
                0x00,0x03,0x00,0x00,0x00,0x01,0x00,0x12,0x44,0x61,0x74,0x61,0x48,0x61,0x6e,0x64,
                0x6c,0x65,0x72,0x2e,0x68,0x61,0x6e,0x64,0x6c,0x65,0x00,0x02,0x2f,0x35,0x00,0x00,
                0x03,0xa5,0x0a,0x00,0x00,0x00,0x03,0x02,0x00,0x0d,0x65,0x78,0x65,0x63,0x75,0x74,
                0x65,0x5f,0x62,0x61,0x74,0x63,0x68,0x11,0x0a,0x0b,0x01,0x1d,0x73,0x68,0x6f,0x77,
                0x4d,0x65,0x73,0x73,0x61,0x67,0x65,0x42,0x61,0x72,0x06,0x03,0x31,0x1d,0x73,0x68,
                0x6f,0x77,0x43,0x68,0x65,0x63,0x6b,0x49,0x6e,0x42,0x61,0x72,0x06,0x03,0x30,0x13,
                0x64,0x61,0x74,0x61,0x5f,0x68,0x61,0x73,0x68,0x06,0x41,0x61,0x66,0x63,0x39,0x62,
                0x39,0x35,0x33,0x31,0x63,0x30,0x65,0x36,0x31,0x64,0x31,0x31,0x63,0x65,0x34,0x35,
                0x37,0x36,0x66,0x35,0x64,0x36,0x30,0x62,0x38,0x66,0x63,0x1f,0x73,0x68,0x6f,0x77,
                0x41,0x63,0x74,0x69,0x76,0x69,0x74,0x79,0x42,0x61,0x72,0x06,0x06,0x09,0x6c,0x61,
                0x6e,0x67,0x06,0x05,0x74,0x75,0x0f,0x76,0x65,0x72,0x73,0x69,0x6f,0x6e,0x06,0x15,
                0x32,0x30,0x31,0x31,0x31,0x32,0x32,0x30,0x30,0x31,0x1d,0x73,0x68,0x6f,0x77,0x47,
                0x69,0x66,0x74,0x42,0x6f,0x78,0x42,0x61,0x72,0x06,0x06,0x17,0x73,0x68,0x6f,0x77,
                0x52,0x61,0x6e,0x6b,0x42,0x61,0x72,0x06,0x02,0x09,0x68,0x6f,0x73,0x74,0x06,0x57,
                0x68,0x74,0x74,0x70,0x3a,0x2f,0x2f,0x66,0x61,0x72,0x6d,0x2d,0x74,0x72,0x2d,0x66,
                0x62,0x2e,0x73,0x6f,0x63,0x69,0x61,0x6c,0x67,0x61,0x6d,0x65,0x6e,0x65,0x74,0x2e,
                0x63,0x6f,0x6d,0x2f,0x73,0x74,0x61,0x74,0x69,0x63,0x2f,0x17,0x62,0x61,0x74,0x63,
                0x68,0x5f,0x64,0x65,0x6c,0x61,0x79,0x06,0x09,0x34,0x30,0x30,0x30,0x13,0x74,0x72,
                0x61,0x6e,0x73,0x70,0x6f,0x72,0x74,0x06,0x49,0x68,0x74,0x74,0x70,0x3a,0x2f,0x2f,
                0x66,0x61,0x72,0x6d,0x2d,0x74,0x72,0x2d,0x66,0x62,0x2e,0x73,0x6f,0x63,0x69,0x61,
                0x6c,0x67,0x61,0x6d,0x65,0x6e,0x65,0x74,0x2e,0x63,0x6f,0x6d,0x2f,0x1b,0x61,0x63,
                0x68,0x69,0x65,0x76,0x65,0x6d,0x65,0x6e,0x74,0x4f,0x6e,0x06,0x02,0x29,0x73,0x68,
                0x6f,0x77,0x5f,0x6e,0x6f,0x5f,0x61,0x63,0x74,0x69,0x6f,0x6e,0x5f,0x70,0x6f,0x70,
                0x75,0x70,0x06,0x13,0x32,0x34,0x30,0x30,0x30,0x30,0x30,0x30,0x30,0x07,0x75,0x69,
                0x64,0x06,0x13,0x37,0x31,0x35,0x39,0x30,0x36,0x37,0x35,0x36,0x21,0x73,0x68,0x6f,
                0x77,0x4c,0x6f,0x76,0x65,0x50,0x6f,0x69,0x6e,0x74,0x42,0x61,0x72,0x06,0x06,0x07,
                0x6d,0x6f,0x64,0x06,0x11,0x66,0x61,0x63,0x65,0x62,0x6f,0x6f,0x6b,0x17,0x73,0x68,
                0x6f,0x77,0x58,0x6d,0x61,0x73,0x42,0x61,0x72,0x06,0x06,0x21,0x73,0x68,0x6f,0x77,
                0x48,0x61,0x6c,0x6c,0x6f,0x77,0x65,0x65,0x6e,0x42,0x61,0x72,0x06,0x06,0x2b,0x73,
                0x68,0x6f,0x77,0x41,0x63,0x63,0x65,0x70,0x74,0x47,0x69,0x66,0x74,0x73,0x42,0x75,
                0x74,0x74,0x6f,0x6e,0x06,0x06,0x1f,0x73,0x68,0x6f,0x77,0x44,0x72,0x61,0x77,0x47,
                0x69,0x66,0x74,0x42,0x61,0x72,0x06,0x06,0x0b,0x71,0x75,0x65,0x75,0x65,0x09,0x09,
                0x01,0x0a,0x01,0x0d,0x6d,0x65,0x74,0x68,0x6f,0x64,0x06,0x1f,0x63,0x6f,0x6c,0x6c,
                0x65,0x63,0x74,0x5f,0x70,0x72,0x6f,0x64,0x75,0x63,0x74,0x09,0x64,0x61,0x74,0x61,
                0x0a,0x01,0x05,0x69,0x64,0x04,0x04,0x13,0x75,0x6e,0x69,0x71,0x75,0x65,0x5f,0x69,
                0x64,0x04,0x0d,0x03,0x78,0x04,0x12,0x13,0x61,0x75,0x74,0x6f,0x6d,0x61,0x74,0x69,
                0x63,0x02,0x03,0x79,0x04,0x16,0x01,0x01,0x0a,0x01,0x40,0x06,0x42,0x44,0x0a,0x01,
                0x46,0x04,0x04,0x48,0x04,0x0f,0x4a,0x04,0x12,0x4c,0x02,0x4e,0x04,0x1e,0x01,0x01,
                0x0a,0x01,0x40,0x06,0x42,0x44,0x0a,0x01,0x46,0x04,0x04,0x48,0x04,0x0a,0x4a,0x04,
                0x0e,0x4c,0x02,0x4e,0x04,0x1e,0x01,0x01,0x0a,0x01,0x40,0x06,0x42,0x44,0x0a,0x01,
                0x46,0x04,0x04,0x48,0x04,0x08,0x4a,0x04,0x0e,0x4c,0x02,0x4e,0x04,0x16,0x01,0x01,
                0x23,0x73,0x68,0x6f,0x77,0x49,0x6e,0x76,0x69,0x74,0x65,0x54,0x61,0x73,0x6b,0x42,
                0x61,0x72,0x06,0x06,0x39,0x66,0x65,0x72,0x74,0x69,0x6c,0x69,0x7a,0x65,0x5f,0x74,
                0x6f,0x5f,0x66,0x72,0x69,0x65,0x6e,0x64,0x5f,0x66,0x65,0x65,0x64,0x5f,0x6d,0x61,
                0x78,0x06,0x03,0x32,0x1f,0x73,0x68,0x6f,0x77,0x45,0x78,0x63,0x68,0x61,0x6e,0x67,
                0x65,0x42,0x61,0x72,0x06,0x06,0x2d,0x73,0x68,0x6f,0x77,0x42,0x75,0x79,0x43,0x61,
                0x73,0x68,0x49,0x74,0x65,0x6d,0x54,0x69,0x6d,0x65,0x6f,0x75,0x74,0x06,0x11,0x38,
                0x36,0x34,0x30,0x30,0x30,0x30,0x30,0x29,0x66,0x65,0x65,0x64,0x5f,0x72,0x65,0x77,
                0x61,0x72,0x64,0x5f,0x66,0x65,0x65,0x64,0x5f,0x6d,0x61,0x78,0x06,0x03,0x36,0x1b,
                0x6e,0x65,0x74,0x77,0x6f,0x72,0x6b,0x5f,0x64,0x65,0x6c,0x61,0x79,0x06,0x0d,0x33,
                0x30,0x30,0x30,0x30,0x30,0x13,0x70,0x6c,0x69,0x6e,0x67,0x61,0x4b,0x65,0x79,0x06,
                0x15,0x31,0x33,0x32,0x39,0x38,0x35,0x32,0x37,0x31,0x30,0x2b,0x73,0x68,0x6f,0x77,
                0x56,0x69,0x70,0x44,0x61,0x69,0x6c,0x79,0x52,0x65,0x77,0x61,0x72,0x64,0x42,0x61,
                0x72,0x06,0x06,0x17,0x66,0x62,0x5f,0x73,0x69,0x67,0x5f,0x75,0x73,0x65,0x72,0x06,
                0x2e,0x1b,0x70,0x6c,0x69,0x6e,0x67,0x61,0x53,0x65,0x73,0x73,0x69,0x6f,0x6e,0x06,
                0x41,0x31,0x62,0x35,0x64,0x36,0x32,0x62,0x31,0x63,0x39,0x31,0x33,0x31,0x62,0x61,
                0x63,0x65,0x39,0x32,0x65,0x64,0x62,0x62,0x33,0x32,0x31,0x64,0x64,0x62,0x31,0x37,
                0x65,0x17,0x73,0x77,0x66,0x5f,0x76,0x65,0x72,0x73,0x69,0x6f,0x6e,0x04,0x4f,0x0f,
                0x63,0x61,0x6c,0x6c,0x5f,0x69,0x64,0x06,0x23,0x63,0x61,0x6c,0x6c,0x31,0x33,0x32,
                0x39,0x38,0x35,0x32,0x37,0x36,0x33,0x31,0x30,0x36,0x01,0x02,0x00,0x09,0x73,0x61,
                0x76,0x65,0x5f,0x64,0x61,0x74,0x61
            };
            bool ret = target.ProcessData(pmData);

            Assert.IsTrue(ret);
        }

        [TestMethod()]
        public void ProcessDataTest22Response()
        {
            AMFDataParser target = new AMFDataParser(); // TODO: Initialize to an appropriate value

            //0x65,0x34,0x0d,0x0a
            byte[] pmData = {
                0x00,0x03,0x00,0x00,0x00,0x01,0x00,0x0b,0x2f,0x35,0x2f,0x6f,
                0x6e,0x52,0x65,0x73,0x75,0x6c,0x74,0x00,0x00,0xff,0xff,0xff,0xff,0x11,0x0a,0x0b,
                0x01,0x0f,0x63,0x68,0x61,0x6e,0x6e,0x65,0x6c,0x06,0x13,0x73,0x61,0x76,0x65,0x5f,
                0x64,0x61,0x74,0x61,0x17,0x73,0x77,0x66,0x5f,0x76,0x65,0x72,0x73,0x69,0x6f,0x6e,
                0x04,0x4f,0x13,0x64,0x61,0x74,0x61,0x5f,0x68,0x61,0x73,0x68,0x06,0x41,0x61,0x66,
                0x63,0x39,0x62,0x39,0x35,0x33,0x31,0x63,0x30,0x65,0x36,0x31,0x64,0x31,0x31,0x63,
                0x65,0x34,0x35,0x37,0x36,0x66,0x35,0x64,0x36,0x30,0x62,0x38,0x66,0x63,0x0b,0x73,
                0x74,0x61,0x74,0x65,0x06,0x05,0x6f,0x6b,0x0f,0x63,0x61,0x6c,0x6c,0x5f,0x69,0x64,
                0x06,0x1b,0x31,0x33,0x32,0x39,0x38,0x35,0x32,0x37,0x36,0x33,0x31,0x30,0x36,0x13,
                0x66,0x65,0x65,0x64,0x5f,0x64,0x61,0x74,0x61,0x02,0x23,0x6f,0x62,0x6a,0x65,0x63,
                0x74,0x73,0x5f,0x74,0x6f,0x5f,0x75,0x70,0x64,0x61,0x74,0x65,0x09,0x01,0x01,0x15,
                0x73,0x74,0x6f,0x72,0x79,0x5f,0x64,0x61,0x74,0x61,0x09,0x01,0x03,0x31,0x0a,0x01,
                0x05,0x31,0x35,0x06,0x03,0x34,0x05,0x31,0x37,0x04,0x00,0x01,0x03,0x32,0x0a,0x01,
                0x05,0x31,0x36,0x04,0x00,0x05,0x31,0x38,0x04,0x00,0x01,0x05,0x31,0x39,0x0a,0x01,
                0x05,0x31,0x30,0x04,0x00,0x01,0x01,0x01,0x0d,0x0a,0x30
            };
            bool ret = target.ProcessData(pmData);

            Debug.WriteLine(target.GetDebugMessage());
            Assert.IsTrue(ret);
        }

        [TestMethod()]
        public void ProcessDataTestGame576Response()
        {
            AMFDataParser target = new AMFDataParser(); // TODO: Initialize to an appropriate value

            byte[] pmData = {
                0x00,0x00,0x00,0x01,0x00,0x12,0x41,0x70,0x70,0x65,0x6e,0x64,0x54,0x6f,0x47,0x61,
                0x74,0x65,0x77,0x61,0x79,0x55,0x72,0x6c,0x00,0x00,0x00,0x00,0x0e,0x02,0x00,0x0b,
                0x3f,0x50,0x48,0x50,0x53,0x45,0x53,0x53,0x49,0x44,0x3d,0x00,0x01,0x00,0x0b,0x2f,
                0x35,0x2f,0x6f,0x6e,0x52,0x65,0x73,0x75,0x6c,0x74,0x00,0x04,0x6e,0x75,0x6c,0x6c,
                0x00,0x00,0x00,0x98,0x11,0x0a,0x0b,0x01,0x17,0x73,0x77,0x66,0x5f,0x76,0x65,0x72,
                0x73,0x69,0x6f,0x6e,0x04,0x62,0x13,0x64,0x61,0x74,0x61,0x5f,0x68,0x61,0x73,0x68,
                0x06,0x03,0x31,0x23,0x6f,0x62,0x6a,0x65,0x63,0x74,0x73,0x5f,0x74,0x6f,0x5f,0x75,
                0x70,0x64,0x61,0x74,0x65,0x09,0x03,0x01,0x0a,0x0b,0x01,0x15,0x73,0x74,0x61,0x72,
                0x74,0x5f,0x74,0x69,0x6d,0x65,0x05,0x41,0xd3,0xd1,0x55,0x91,0x80,0x00,0x00,0x13,
                0x75,0x6e,0x69,0x71,0x75,0x65,0x5f,0x69,0x64,0x04,0x02,0x01,0x13,0x66,0x65,0x65,
                0x64,0x5f,0x64,0x61,0x74,0x61,0x02,0x0b,0x73,0x74,0x61,0x74,0x65,0x06,0x05,0x6f,
                0x6b,0x0f,0x63,0x61,0x6c,0x6c,0x5f,0x69,0x64,0x06,0x1b,0x31,0x33,0x32,0x39,0x39,
                0x34,0x34,0x31,0x33,0x31,0x39,0x34,0x31,0x0f,0x63,0x68,0x61,0x6e,0x6e,0x65,0x6c,
                0x06,0x13,0x73,0x61,0x76,0x65,0x5f,0x64,0x61,0x74,0x61,0x01
            };

            target.DebugLevel = 100;
            bool ret = target.ProcessData(pmData);

            Debug.WriteLine(target.GetDebugMessage());
            Assert.IsTrue(ret);
        }

    }
}
