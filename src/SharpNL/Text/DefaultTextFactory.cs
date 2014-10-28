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

using System;
using SharpNL.Utility;

namespace SharpNL.Text {

    /// <summary>
    /// The factory that provides the default implementations and resources for the SharpNL text objects. 
    /// This class cannot be inherited.
    /// </summary>
    public sealed class DefaultTextFactory : ITextFactory {

        #region . Instance .
        /// <summary>
        /// Gets the <see cref="DefaultTextFactory"/> instance.
        /// </summary>
        /// <value>The <see cref="DefaultTextFactory"/> instance.</value>
        public static DefaultTextFactory Instance { get; private set; }
        #endregion

        #region + Constructors .
        /// <summary>
        /// Initializes static members of the <see cref="DefaultTextFactory"/> class.
        /// </summary>
        static DefaultTextFactory() {
            Instance = new DefaultTextFactory();
        }
        /// <summary>
        /// Prevents a default instance of the <see cref="DefaultTextFactory"/> class from being created.
        /// </summary>
        private DefaultTextFactory() { }
        #endregion

        #region . CreateChunk .
        /// <summary>
        /// Creates the <see cref="IChunk"/> object.
        /// </summary>
        /// <param name="sentence">The sentence.</param>
        /// <param name="span">The chunk span.</param>
        /// <returns>The <see cref="IChunk"/> representation.</returns>
        public Chunk CreateChunk(Sentence sentence, Span span) {
            if (sentence == null)
                throw new ArgumentNullException("sentence");

            if (span == null)
                throw new ArgumentNullException("span");

            return new Chunk(sentence, span);
        }
        IChunk ITextFactory.CreateChunk(ISentence sentence, Span span) {
            var s = sentence as Sentence;
            if (s != null)
                return CreateChunk(s, span);

            throw new NotSupportedException("The sentence type " + sentence.GetType().Name + " is not supported.");
        }
        #endregion

        #region . CreateDocument .
        /// <summary>
        /// Creates the document object.
        /// </summary>
        /// <param name="language">The language.</param>
        /// <param name="text">The text.</param>
        /// <returns>The created <see cref="IDocument"/> object.</returns>
        public Document CreateDocument(string language, string text) {
            return new Document(language, text);
        }

        IDocument ITextFactory.CreateDocument(string language, string text) {
            return CreateDocument(language, text);
        }
        #endregion

        #region . CreateEntity .
        /// <summary>
        /// Creates an entity object.
        /// </summary>
        /// <param name="sentence">The sentence where the entity is present.</param>
        /// <param name="span">The entity span.</param>
        /// <returns>The new <see cref="IEntity"/> object.</returns>
        public Entity CreateEntity(Sentence sentence, Span span) {
            return new Entity(span, sentence);
        }
        IEntity ITextFactory.CreateEntity(ISentence sentence, Span span) {
            var s = sentence as Sentence;
            if (s != null)
                return CreateEntity(s, span);

            throw new NotSupportedException("The sentence type " + sentence.GetType().Name + " is not supported.");
        }
        #endregion

        #region . CreateSentence .
        /// <summary>
        /// Creates a sentence object.
        /// </summary>
        /// <param name="span">The sentence span</param>
        /// <param name="document">The document.</param>
        /// <returns>The created <see cref="ISentence" /> object.</returns>
        /// <exception cref="System.ArgumentNullException">
        /// <paramref name="span"/>
        /// or
        /// <paramref name="document"/>
        /// </exception>
        public Sentence CreateSentence(Span span, Document document) {
            if (span == null)
                throw new ArgumentNullException("span");

            if (document == null)
                throw new ArgumentNullException("document");

            return new Sentence(span.Start, span.End, document);
        }
        ISentence ITextFactory.CreateSentence(Span span, IDocument document) {
            if (document == null)
                throw new ArgumentNullException("document");

            var d = document as Document;
            if (d != null)
                return CreateSentence(span, (Document)document);

            throw new NotSupportedException("The sentence type " + document.GetType().Name + " is not supported.");
        }
        #endregion

        #region . CreateToken .

        /// <summary>
        /// Creates an token object.
        /// </summary>
        /// <param name="start">The start position.</param>
        /// <param name="end">The end position.</param>
        /// <param name="lexeme">The lexeme.</param>
        /// <param name="probability">The token probability.</param>
        /// <returns>The created <see cref="IToken"/> object.</returns>
        public Token CreateToken(int start, int end, string lexeme, double probability) {
            return new Token(start, end, lexeme) {
                Probability = probability
            };
        }
        IToken ITextFactory.CreateToken(int start, int end, string lexeme, double probability) {
            return CreateToken(start, end, lexeme, probability);
        }
        #endregion

    }
}