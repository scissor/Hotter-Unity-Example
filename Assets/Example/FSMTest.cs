using UnityEngine;
using System.Collections;
using Hotter.Utilities;

public class FSMTest : TestUnit
{
    private enum GameState
    {
        None,
        StartGame,
        Playing,
        EndGame
    }

    private FSM<GameState> m_state = new FSM<GameState>( GameState.None );

    #region FSM

    void Update()
    {
        switch ( m_state.Tick() )
        {
        case GameState.StartGame:
            StateStartGame();
            break;

        case GameState.Playing:
            StatePlaying();
            break;

        case GameState.EndGame:
            StateEndGame();
            break;
        }
    }

    private void StateStartGame()
    {
        if ( m_state.IsEntering )
        {
            Debug.Log( this, "StateStartGame" );

            m_state.Transit( GameState.Playing );
        }
    }

    private void StatePlaying()
    {
        if ( m_state.IsEntering )
        {
            Debug.Log( this, "StatePlaying: Play for 3 seconds..." );
        }

        if ( m_state.Elapsed > 3 )
        {
            m_state.Transit( GameState.EndGame );
        }
    }

    private void StateEndGame()
    {
        if ( m_state.IsEntering )
        {
            Debug.Log( this, "StateEndGame" );
        }
    }

    #endregion

    public override void Log()
    {
        m_state.Transit( GameState.StartGame );
    }
}
