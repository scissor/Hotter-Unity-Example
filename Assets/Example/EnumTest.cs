using UnityEngine;
using System.Collections;
using System;
using Hotter.Utilities;

public class EnumTest : TestUnit
{
    public enum TestEnum
    {
        Test1,
        Test2,
        Test3
    }

    public override void Log()
    {
        Debug.LogBold( "=== EnumHelper.GetValues() ===" );
        foreach ( var test in EnumHelper.GetValues<TestEnum>() )
        {
            Debug.Log( this, test.ToString() );
        }

        Debug.LogBold( "=== EnumHelper.CircularNext() ===" );
        var enumTest = TestEnum.Test1;
        for ( int i = 0; i < EnumHelper.Count<TestEnum>(); ++i )
        {
            Debug.Log( this, enumTest );
            enumTest = EnumHelper.CircularNext( enumTest );
        }

        Debug.LogBold( "=== EnumHelper.Random() ===" );
        for ( int i = 0; i < EnumHelper.Count<TestEnum>(); ++i )
        {
            Debug.Log( this, EnumHelper.Random<TestEnum>() );
        }
    }
}
