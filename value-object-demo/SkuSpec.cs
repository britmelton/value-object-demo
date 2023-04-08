﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using value_object_demo.Domain;

namespace value_object_demo
{
    public class SkuSpec
    {
        public class WhenEvaluatingEquality : ValueObjectSpec.WhenEvaluatingEquality
        {
            public override ValueObject Create()
            {
                return new Sku("abc123");
            }

            public override ValueObject CreateOther()
            {
                return new Sku("abc124");
            }
        }

        public class WhenCreating
        {
            [Theory]
            [InlineData("abc123")]
            [InlineData("wdg458")]
            public void WithValidValue_ThenSkuIsReturned(string value)
            {
                var sku = new Sku(value);

                sku.Should().NotBeNull();
                sku.Value.Should().Be(value);

            }

            [Theory]
            [InlineData("ws256")]
            [InlineData("wser256")]
            [InlineData("145")]
            [InlineData("!@#256")]
            [InlineData(null)]
            [InlineData("")]
            public void WithoutThreeStartLetters_ThenThrowArgumentException(string value)
            {
                //write action (anonymous function that does thing)
                Action createInvalidSku = () => new Sku(value);
                createInvalidSku.Should().Throw<ArgumentException>();
            }

            [Theory]
            [InlineData("wss25")]
            [InlineData("wsr2565")]
            [InlineData("skd")]
            [InlineData("aws!@#")]
            [InlineData(null)]
            [InlineData("")]
            public void WithoutThreeEndingNumbers_ThenThrowArgumentException(string value)
            {
                //write action (anonymous function that does thing)
                Action createInvalidSku = () => new Sku(value);
                createInvalidSku.Should().Throw<ArgumentException>();
            }

        }
    }
}
