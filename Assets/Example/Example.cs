using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hotter.Utilities;
using UnityEngine;

namespace Hotter
{
    public enum Test
    {
        Debug,
        Enum,
        FSM,
    }

    public class Example : MonoBehaviour
    {
        private IDictionary<Test, TestUnit> m_tests = new Dictionary<Test, TestUnit>();

        void Start()
        {
            m_tests = new Dictionary<Test, TestUnit>()
            {
                { Test.Debug, gameObject.AddComponent<DebugTest>() },
                { Test.Enum, gameObject.AddComponent<EnumTest>() },
                { Test.FSM, gameObject.AddComponent<FSMTest>() },
            };
        }

        void OnGUI()
        {
            float w = 100;
            float h = 50;
            int index = 0;

            foreach ( var test in m_tests )
            {
                if ( GUI.Button( new Rect( 0, index * h, w, h ), test.Key.ToString() ) )
                {
                    test.Value.Log();
                }

                ++index;
            }
        }
    }
}
