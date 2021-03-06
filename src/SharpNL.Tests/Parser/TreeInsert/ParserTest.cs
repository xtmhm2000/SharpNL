﻿// 
//  Copyright 2014 Gustavo J Knuppe (https://github.com/knuppe)
// 
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
// 
//       http://www.apache.org/licenses/LICENSE-2.0
// 
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// 
//   - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
//   - May you do good and not evil.                                         -
//   - May you find forgiveness for yourself and forgive others.             -
//   - May you share freely, never taking more than you give.                -
//   - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
//  

using System.IO;
using NUnit.Framework;
using SharpNL.Parser;
using SharpNL.Utility;

namespace SharpNL.Tests.Parser.TreeInsert {
    [TestFixture]
    internal class ParserTest {

        [Test]
        public void TestTreeInsertParserTraining() {
            var parseSamples = ParserTestUtil.CreateParseTrainStream();
            var headRules = ParserTestUtil.CreateTestHeadRules();

            var model = SharpNL.Parser.TreeInsert.Parser.Train("en", parseSamples, headRules, 100, 0);

            var parser = ParserFactory.Create(model);

            // Tests parsing to make sure the code does not has
            // a bug which fails always with a runtime exception
           var p = parser.Parse(Parse.ParseParse("She was just another freighter from the " +
                   "States and she seemed as commonplace as her name ."));

            ParserModel deserialized;

            using (var data = new MemoryStream()) {
                model.Serialize(new UnclosableStream(data));

                data.Seek(0, SeekOrigin.Begin);

                deserialized = new ParserModel(data);
            }

            Assert.NotNull(deserialized);


            // TODO: compare both models
        }
    }
}