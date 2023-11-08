using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// An enum defines a variable type with a few prenamed values // a
public enum Golf_eCardState
{
    drawpile,
    tableau,
    target,
    discard
}
public class Golf_CardProspector : Card
{ // Make sure CardProspector extends
    
    [Header("Set Dynamically: Golf_CardProspector")]
// This is how you use the enum eCardState
public Golf_eCardState state = Golf_eCardState.drawpile;
    // The hiddenBy list stores which other cards will keep this one face
   
public List<Golf_CardProspector> hiddenBy = new List<Golf_CardProspector>();
    // The layoutID matches this card to the tableau XML if it's a tableau
    
public int layoutID;
// The SlotDef class stores information pulled in from the LayoutXML

public SlotDef slotDef;

    override public void OnMouseUpAsButton()
    {
        // Call the CardClicked method on the Prospector singleton
        Golf_Prospector.S.CardClicked(this);
        // Also call the base class (Card.cs) version of this method
        base.OnMouseUpAsButton(); // a
    }

}