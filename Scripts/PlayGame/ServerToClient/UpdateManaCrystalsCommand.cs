using System.Collections;

public class UpdateManaCrystalsCommand : Command {

    public int m_playerID;
    public int m_totalMana;
    public int m_availableMana;

    public UpdateManaCrystalsCommand(int playerID, int totalMana, int availableMana)
    {
        this.m_playerID = playerID;
        this.m_totalMana = totalMana;
        this.m_availableMana = availableMana;
        Response.ServerSend("UpdateManaCrystal");
    }

    public override void StartCommandExecution()
    {
        OneSceneManager.Instance.StageDictByPlayerId[this.m_playerID].UpdateManaPool(this.m_availableMana,this.m_totalMana);

    }
}
