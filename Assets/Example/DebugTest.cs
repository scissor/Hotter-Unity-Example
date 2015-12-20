public class DebugTest : TestUnit
{
    public override void Log()
    {
        Debug.Log( "Log" );
        Debug.LogError( "LogError" );
        Debug.LogWarning( "LogWarning" );
        Debug.LogBold( "LogBold" );
        Debug.LogItalic( "LogItalic" );
        Debug.LogColor( "LogRed", "red" );
        Debug.LogColor( "LogYellow", "yellow" );
        Debug.LogColor( "LogGreen", "green" );

        Debug.FontSize = 14;
        Debug.Log( "FontSize: " + Debug.FontSize );

        // Filter
        Debug.Log( this, "Before adding" );
        Debug.Add( this );

        Debug.Log( this, "Filter Log" );
        Debug.LogWarning( this, "Filter LogWarning" );
        Debug.LogError( this, "Filter LogError" );

        Debug.Remove( this );
        Debug.Log( this, "After removing" );
    }
}
