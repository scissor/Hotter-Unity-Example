# Hotter-Unity-Example
Unity Example Project for using Hotter

### Debug
Custom Debug that overrides UnityEngine.Debug.

```c#
// Mute
Debug.IsEnabled = false;

// Filter
Debug.Add( this );
Debug.Log( this, "Message" );

// FontSize
Debug.FontSize = 14;

// RichText
Debug.LogBold( "LogBold" );
Debug.LogItalic( "LogItalic" );
Debug.LogColor( "LogRed", "red" );
```

### Finite State Machine (FSM)

```c#
enum GameState
{
  None,
  StartGame,
  Playing,
  EndGame
}

var FSM<GameState> m_state = new FSM<GameState>( GameState.None );
m_state.Transit( GameState.StartGame );

void Update()
{
  switch ( m_state.Tick() )
  {
    case GameState.StartGame: break;
    case GameState.Playing: break;
    case GameState.EndGame: break;     
  }
}
```
