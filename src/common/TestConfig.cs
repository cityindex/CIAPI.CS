﻿using System;
using System.Configuration;

namespace CIAPI.Tests
{
    public class Settings
    {
        public static Uri RpcUri
        {
            get
            {
                return new Uri(ConfigurationManager.AppSettings["apiRpcUrl"]);
            }
        }

        public static Uri StreamingUri
        {
            get
            {
                return new Uri(ConfigurationManager.AppSettings["apiStreamingUrl"]);
            }
        }

        public static string RpcUserName
        {
            get
            {
                return Environment.GetEnvironmentVariable("CIAPI_USERNAME");
            }
        }

        public static string RpcPassword
        {
            get
            {
                return Environment.GetEnvironmentVariable("CIAPI_PASSWORD");
            }
        }

        public static string AppMetrics_UserName
        {
            get
            {
                return Environment.GetEnvironmentVariable("AppMetricsTest_UserName");
            }
        }

        public static string AppMetrics_Password
        {
            get
            {
                return Environment.GetEnvironmentVariable("AppMetricsTest_Password");
            }
        }

        public static string AppMetrics_AccessKey
        {
            get
            {
                return Environment.GetEnvironmentVariable("AppMetricsTest_AccessKey");
            }
        }

    }
}