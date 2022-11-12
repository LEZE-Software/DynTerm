using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace term
{
    public class LabelAction
    {
        public bool displayPortState;
    }

    public struct Keyword
    {
        public string text;
        public KeywordCheckOperation CheckIdx;
    }

    public struct TargetProp
    {
        public string
            textToDisplay,
            displayTextPos,
            displayTextNeg;

        public ControlObject
            targetObjectPos,
            targetObjectNeg,
            targetObject;

        public Color
            targetObjectColorPos,
            targetObjectColorNeg;

        public DisplayOperation DispIxd;

        public bool
            changeColorOfTargetObject;

        public void DisplayText(Keyword key)
        {
            if(DispIxd==DisplayOperation.Keyword)
            {
                targetObject.rootObject.Text = key.text;
            }
            else if(DispIxd==DisplayOperation.DisplayText)
            {
                targetObject.rootObject.Text = textToDisplay;            
            }
        }
       
        public void DisplaySerialAnswer(string serial)
        {
            targetObject.rootObject.Text = serial;
        }

        public void DisplayTextPos()
        {
            if(changeColorOfTargetObject)
            {
                targetObjectPos.rootObject.ForeColor = targetObjectColorPos;
            }

            targetObjectPos.rootObject.Text = displayTextPos;
        }

        public void DisplayTextNeg()
        {
            if (changeColorOfTargetObject)
            {
                targetObjectNeg.rootObject.ForeColor = targetObjectColorNeg;
            }

            targetObjectNeg.rootObject.Text = displayTextNeg;
        }
    }

    public struct SerialAnswer
    {
        public string 
            answer,
            answerPos,            
            answerNeg;

        public ControlObject
            sourceObjectPos,
            sourceObjectNeg;

        public SendOperationIndex sendIdx;

        public bool sendSerialMessage;
    }
}
