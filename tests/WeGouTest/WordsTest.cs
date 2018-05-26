﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using WeGouSharp;
using WeGouSharp.Model;
using Xunit;

namespace WeGouTest
{
    public class WordsTest : BasicConfig
    {
        WeGou api;

        public WordsTest()
        {
            api = new WeGou();
        }

        [Fact]
        public void TestGetSuggestKeyWords()
        {
            var rs = api.GetSuggestKeyWords("广州大学城");
            var articles = JsonConvert.DeserializeObject<List<Article>>(rs);
            Assert.True(rs.Length > 0);
        }
        
        [Fact]
        public void TestGetTopWords()
        {
            var rs = api.GetTopWords();
            var articles = JsonConvert.DeserializeObject<List<Article>>(rs);
            Assert.True(rs.Length > 0);
        }
        
        
        [Fact]
        public void TestResolveArticleByHtml()
        {
            var rs = api.ResolveArticleByHtml("");
            var articles = JsonConvert.DeserializeObject<List<Article>>(rs);
            Assert.True(rs.Length > 0);
        }
        
        
    }
}