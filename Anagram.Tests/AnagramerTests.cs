﻿namespace Anagram.Tests;

[TestClass]
public class AnagramerTests
{
    [TestMethod]
    public void ReverseTestSpace()
    {
        var space = " ";

        var expected = space;

        var actual = Anagramer.Reverse(space);
        
        Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    public void ReverseTestManySpaces()
    {
        var spaces = "       ";

        var expected = spaces;

        var actual = Anagramer.Reverse(spaces);
        
        Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    public void ReverseTestAlphabeticOnly()
    {
        var line = "abcd efgh";

        var expected = "dcba hgfe";

        var actual = Anagramer.Reverse(line);
        
        Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    public void ReverseTestWithOneSymbol()
    {
        var line = "a1bcd efg!h";

        var expected = "d1cba hgf!e";

        var actual = Anagramer.Reverse(line);
        
        Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    public void ReverseTestWithManySymbols()
    {
        var line = "a1b212121cd e/%f23g!hqwe@as";

        var expected = "d1c212121ba s/%a23e!wqhg@fe";

        var actual = Anagramer.Reverse(line);
        
        Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    public void ReverseTestHalfWordSymbols()
    {
        var line = "asdfg1234@";

        var expected = "gfdsa1234@";

        var actual = Anagramer.Reverse(line);
        
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ReverseTestTrim()
    {
        var line = "  a1bcd    efg!h";

        var expected = "  d1cba    hgf!e";

        var actual = Anagramer.Reverse(line);
        
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    [ExpectedException(typeof(NullForReverseException))]
    public void ReverseTestNull()
    {
        Anagramer.Reverse(null!);
    }

    [TestMethod]
    public void ReverseTestHalf()
    {
        var line = "12345!@#$%qwertyuiop qwertyuiop12345!@#$%";

        var expected = "12345!@#$%poiuytrewq poiuytrewq12345!@#$%";

        var actual = Anagramer.Reverse(line);
        
        Assert.AreEqual(expected, actual);
    }
}