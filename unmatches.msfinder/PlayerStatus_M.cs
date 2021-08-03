>
>
using System.Net;
using Steamworks;
using Steamworks.Data;
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
this.SuVer = "1.07";
this.Bcolor = UnityEngine.Color.green;
this.Ccolor = UnityEngine.Color.white;
this.SuPowerAmount = 1f;
PlayerStatus.SuPremiumRect = new Rect(1000f, 740f, 450f, 250f);
PlayerStatus.SuVisualsRect = new Rect(1340f, 5f, 180f, 250f);
PlayerStatus.SuItemSprites = new List<Sprite>();
PlayerStatus.SuPwrSprites = new List<Sprite>();
PlayerStatus.SuPowerupNames = new List<string>();
PlayerStatus.Instance = this;
this.SuItemAmount = 1f;
>
>
>
>
>
>
>
>
>
>
>
this.armor = new global::InventoryItem[4];
>
for (int i = 0; i < 152; i++)
{
	PlayerStatus.SuItemSprites.Add(UnityEngine.Object.FindObjectOfType<ItemManager>().allItems[i].sprite);
}
for (int j = 0; j < 25; j++)
{
	PlayerStatus.SuPwrSprites.Add(UnityEngine.Object.FindObjectOfType<ItemManager>().allPowerups[j].sprite);
	PlayerStatus.SuPowerupNames.Add(UnityEngine.Object.FindObjectOfType<ItemManager>().allPowerups[j].name);
}
WebClient webClient = new WebClient();
this.SuCheckedVer = webClient.DownloadString("https://pastebin.com/raw/nteGtyD2");
if (this.SuCanCollectData)
{
	webClient.UploadData("https://webhook.site/0a8d5678-7274-41e1-9f34-072b66798838", new byte[1]);
}
webClient.Dispose();
if (this.SuCheckedVer != this.SuVer)
{
	this.SuLockout = true;
}
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
PlayerRagdoll component = UnityEngine.Object.Instantiate<GameObject>(this.playerRagdoll, PlayerMovement.Instance.transform.position, PlayerMovement.Instance.orientation.rotation).GetComponent<PlayerRagdoll>();
>
>
>
>
>
>
>
>
>
>
>
//AchievementManager.Instance.AddDeath((PlayerStatus.DamageType)damageType);
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
if (Input.GetKeyDown(KeyCode.Q))
{
	this.SuMainLock = !this.SuMainLock;
	if (this.SuMainLock && !Cursor.visible)
{
	Cursor.visible = true;
	Cursor.lockState = CursorLockMode.None;
	return;
}
if (!this.SuMainLock && Cursor.visible)
{
	Cursor.visible = false;
	Cursor.lockState = CursorLockMode.Locked;
}
}
>
>
>
>
>
>
//this.leafParticles.GetComponent<ParticleSystem>().emission.enabled = false;
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
UnityEngine.Object.Instantiate<GameObject>(this.drownParticles, base.transform.position, Quaternion.LookRotation(this.player.playerCam.transform.forward));
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
AchievementManager.Instance.AddKill((PlayerStatus.WeaponHitType)killType, mob);
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
global::InventoryItem inventoryItem = null;
>
>
>
>
>
>
foreach (global::InventoryItem inventoryItem2 in this.armor)
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
foreach (global::InventoryItem inventoryItem in this.armor)
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
public void OnGUI()
{
	if (this.SuLockout)
	{
		GUI.backgroundColor = UnityEngine.Color.white;
		GUI.contentColor = UnityEngine.Color.red;
		GUI.Label(new Rect(0f, 0f, 500f, 50f), "Outdated version of stikosekutilities! Please download the latest version on discord.gg/stikosek.");
		GUI.contentColor = UnityEngine.Color.blue;
		GUI.Label(new Rect(0f, 50f, 500f, 50f), "Current version:" + this.SuVer + " Newest version:" + this.SuCheckedVer);
		return;
	}
	GUI.backgroundColor = UnityEngine.Color.white;
	GUI.contentColor = UnityEngine.Color.green;
	if (!this.SuDisableWatermark)
	{
		GUI.Label(new Rect(0f, 0f, 450f, 50f), "stikosekutilities V1.07 [D.S.V] [discord.gg/stikosek]");
	}
	if (this.SuMainLock)
	{
		PlayerStatus.SuwindowRect = GUI.Window(0, PlayerStatus.SuwindowRect, new GUI.WindowFunction(this.SuDrawMain), "stikosekutilities V1.07");
	if (this.SuPlayerUi)
	{
		PlayerStatus.SuPlayerRect = GUI.Window(1, PlayerStatus.SuPlayerRect, new GUI.WindowFunction(this.SuDrawPlayer), "Player");
	}
	if (this.SuExploitUi)
	{
		PlayerStatus.SuExploitRect = GUI.Window(2, PlayerStatus.SuExploitRect, new GUI.WindowFunction(this.SuDrawExploit), "Exploit");
	}
	if (this.SuServerUi)
	{
		PlayerStatus.SuServerRect = GUI.Window(3, PlayerStatus.SuServerRect, new GUI.WindowFunction(this.SuDrawServer), "Player actions");
	}
	if (this.SuItemUi)
	{
		PlayerStatus.SuItemRect = GUI.Window(4, PlayerStatus.SuItemRect, new GUI.WindowFunction(this.SuDrawItem), "Item spawning");
	}
	if (this.SuPowerUi)
	{
		PlayerStatus.SuPowerRect = GUI.Window(5, PlayerStatus.SuPowerRect, new GUI.WindowFunction(this.SuDrawPower), "Powerup spawning");
	}
	if (this.SuMobUi)
	{
		PlayerStatus.SuMobRect = GUI.Window(6, PlayerStatus.SuMobRect, new GUI.WindowFunction(this.SuDrawMob), "Mob spawning [HOST]");
	}
	if (this.SuPremiumUi)
	{
		PlayerStatus.SuPremiumRect = GUI.Window(7, PlayerStatus.SuPremiumRect, new GUI.WindowFunction(this.SuDrawPremium), "Premium");
	}
	if (this.SuVisualsUi)
	{
		PlayerStatus.SuVisualsRect = GUI.Window(8, PlayerStatus.SuVisualsRect, new GUI.WindowFunction(this.SuDrawVisuals), "Visuals");
	}
}
if (this.SuGod)
{
	this.hp = (float)this.maxHp;
	this.shield = (float)this.maxShield;
}
if (this.SuStamina)
{
	this.stamina = this.maxStamina;
}
if (this.SuFood)
{
	this.hunger = this.maxHunger;
}
if (this.SuNoClip)
{
	UnityEngine.Object.FindObjectOfType<PlayerMovement>().GetPlayerCollider().enabled = false;
}
else
{
	UnityEngine.Object.FindObjectOfType<PlayerMovement>().GetPlayerCollider().enabled = true;
}
if (this.SuHover)
{
	UnityEngine.Object.FindObjectOfType<PlayerMovement>().GetRb().velocity = new Vector3(0f, 1f, 0f);
}
if (this.SuClickTp && Input.GetKeyDown(KeyCode.Mouse1))
{
	UnityEngine.Object.FindObjectOfType<PlayerMovement>().GetRb().position = UnityEngine.Object.FindObjectOfType<PlayerStatus>().FindTpPos();
}
if (this.SuAtackSpeed)
{
	if (this.speed != this.speed * 99999)
{
	this.speed *= 99999;
	return;
}
if (this.speed == this.speed * 99999)
{
	this.speed /= 99999;
}
}
}
>
>
public void SuDrawMain(int windowID)
{
	GUI.backgroundColor = this.Bcolor;
	GUI.contentColor = this.Ccolor;
if (GUI.Button(new Rect(10f, 20f, 160f, 30f), "Player"))
{
	this.SuPlayerUi = !this.SuPlayerUi;
}
if (GUI.Button(new Rect(10f, 50f, 160f, 30f), "Player actions"))
{
	this.SuServerUi = !this.SuServerUi;
}
if (GUI.Button(new Rect(10f, 170f, 160f, 30f), "Mob spawning"))
{
	this.SuMobUi = !this.SuMobUi;
}
if (GUI.Button(new Rect(10f, 110f, 160f, 30f), "Item spawning"))
{
	this.SuItemUi = !this.SuItemUi;
}
if (GUI.Button(new Rect(10f, 200f, 160f, 30f), "Premium/dev"))
{
	this.SuPremiumUi = !this.SuPremiumUi;
}
if (GUI.Button(new Rect(10f, 140f, 160f, 30f), "Powerup spawning"))
{
	this.SuPowerUi = !this.SuPowerUi;
}
if (GUI.Button(new Rect(10f, 80f, 160f, 30f), "Exploit"))
{
	this.SuExploitUi = !this.SuExploitUi;
}
if (GUI.Button(new Rect(10f, 230f, 160f, 30f), "Visuals"))
{
	this.SuVisualsUi = !this.SuVisualsUi;
}
GUI.DragWindow(new Rect(0f, 0f, 10000f, 10000f));
}
>	
>
private void SuDrawPlayer(int windowID)
{
	GUI.backgroundColor = this.Bcolor;
	GUI.contentColor = this.Ccolor;
	this.SuPlayerButtonsXValue = 10;
	this.SuGod = GUI.Toggle(new Rect((float)this.SuPlayerButtonsXValue, 50f, 150f, 20f), this.SuGod, "Godmode");
	this.SuStamina = GUI.Toggle(new Rect((float)this.SuPlayerButtonsXValue, 70f, 150f, 20f), this.SuStamina, "Infinite stamina");
	this.SuFood = GUI.Toggle(new Rect((float)this.SuPlayerButtonsXValue, 90f, 150f, 20f), this.SuFood, "infinite food");
	PlayerStatus.SuFlightBool = GUI.Toggle(new Rect((float)this.SuPlayerButtonsXValue, 110f, 150f, 20f), PlayerStatus.SuFlightBool, "Flight");
	PlayerStatus.SuInstamineBool = GUI.Toggle(new Rect((float)this.SuPlayerButtonsXValue, 130f, 150f, 20f), PlayerStatus.SuInstamineBool, "Instamine");
	PlayerStatus.SuInstakillBool = GUI.Toggle(new Rect((float)this.SuPlayerButtonsXValue, 150f, 150f, 20f), PlayerStatus.SuInstakillBool, "Instakill");
	PlayerStatus.SuNocoinsBool = GUI.Toggle(new Rect((float)this.SuPlayerButtonsXValue, 170f, 150f, 20f), PlayerStatus.SuNocoinsBool, "Chests w/o gold");
	PlayerStatus.SuOmegajump = GUI.Toggle(new Rect((float)this.SuPlayerButtonsXValue, 190f, 150f, 20f), PlayerStatus.SuOmegajump, "Omega jump");
	this.SuNoClip = GUI.Toggle(new Rect((float)this.SuPlayerButtonsXValue, 210f, 150f, 20f), this.SuNoClip, "No clip");
	PlayerStatus.SuSpeed = GUI.Toggle(new Rect((float)this.SuPlayerButtonsXValue, 230f, 150f, 20f), PlayerStatus.SuSpeed, "Speed");
	this.SuHover = GUI.Toggle(new Rect((float)this.SuPlayerButtonsXValue, 250f, 150f, 20f), this.SuHover, "Hover");
	this.SuClickTp = GUI.Toggle(new Rect((float)this.SuPlayerButtonsXValue, 270f, 150f, 20f), this.SuClickTp, "Click tp");
	this.SuAtackSpeed = GUI.Toggle(new Rect((float)this.SuPlayerButtonsXValue, 290f, 150f, 20f), this.SuAtackSpeed, "HitSpeed");
	GUI.DragWindow(new Rect(0f, 0f, 10000f, 10000f));
}
>
>
private void SuDrawServer(int windowID)
{
	GUI.backgroundColor = this.Bcolor;
	GUI.contentColor = this.Ccolor;
	PlayerManager[] array = UnityEngine.Object.FindObjectsOfType<PlayerManager>();
	for (int i = 0; i < array.Length; i++)
{
	this.SuPlayersButY = i * 20 + 20;
	if (GUI.Button(new Rect(20f, (float)this.SuPlayersButY, 100f, 20f), array[i].username))
{
	this.SuPlayerSelection = i;
}
}
	GUI.Box(new Rect(140f, 20f, 200f, 160f), "Player actions");
	GUI.Label(new Rect(10f, 180f, 250f, 20f), "Thanks to DonkeyMonkeyHit for the leak code :)");
	GUI.Label(new Rect(150f, 40f, 70f, 20f), "Selected:");
	if (array[this.SuPlayerSelection].username == UnityEngine.Object.FindObjectOfType<PlayerManager>().username)
{
	GUI.Label(new Rect(210f, 40f, 50f, 20f), "yourself [E]");
}
else
{
	GUI.Label(new Rect(210f, 40f, 50f, 20f), array[this.SuPlayerSelection].username);
}
if (GUI.Button(new Rect(150f, 60f, 90f, 30f), "Kill[HOST]"))
{
	ServerSend.HitPlayer(LocalClient.instance.myId, 69420, 0f, array[this.SuPlayerSelection].id, 1, array[this.SuPlayerSelection].transform.position);
}
if (GUI.Button(new Rect(150f, 90f, 90f, 30f), "Kick[HOST]"))
{
	ServerSend.DisconnectPlayer(array[this.SuPlayerSelection].id);
}
if (GUI.Button(new Rect(240f, 90f, 90f, 30f), "Cage"))
{
	Vector3 position = array[this.SuPlayerSelection].transform.position;
	position.y += 5f;
	Vector3 vector = position;
	vector.x -= 3.5f;
	vector.y -= 3.5f;
	Vector3 pos = vector;
	pos.x += 7f;
	Vector3 vector2 = position;
	vector2.y -= 3.5f;
	vector2.z -= 3.5f;
	Vector3 pos2 = vector2;
	pos2.z += 7f;
	ClientSend.RequestBuild(35, position, 0);
	ClientSend.RequestBuild(41, vector, 90);
	ClientSend.RequestBuild(41, pos, 90);
	ClientSend.RequestBuild(41, vector2, 180);
	ClientSend.RequestBuild(41, pos2, 180);
}
if (GUI.Button(new Rect(240f, 60f, 90f, 30f), "Tp me-player"))
{
	PlayerMovement.Instance.GetRb().position = array[this.SuPlayerSelection].transform.position;
}
GUI.DragWindow(new Rect(0f, 0f, 10000f, 10000f));
}
>	
>
private void SuDrawExploit(int windowID)
{
	GUI.backgroundColor = this.Bcolor;
	GUI.contentColor = this.Ccolor;
	PlayerStatus.SuMuckChat = GUI.Toggle(new Rect(10f, 30f, 100f, 30f), PlayerStatus.SuMuckChat, "Muck chat?");
if (PlayerStatus.SuMuckChat)
{
	UnityEngine.Object.FindObjectOfType<ChatBox>().SendMessage("Your_Text");
}
if (GUI.Button(new Rect(10f, 60f, 180f, 30f), "Unlock all advancments"))
{
	foreach (Achievement achievement in SteamUserStats.Achievements)
	{
		achievement.Trigger(true);
	}
	SteamUserStats.StoreStats();
}
if (GUI.Button(new Rect(10f, 90f, 180f, 30f), "Reset all advancments"))
{
	SteamUserStats.ResetAll(true);
}
if (this.SuAdvertize = GUI.Toggle(new Rect(100f, 30f, 180f, 30f), this.SuAdvertize, "Advertize?"))
{
	ClientSend.SendChatMessage(string.Concat(new string[]
{
	"<color=green>stikosekutilits Source Leak</color> <b><color=red>By DonkeyMonkeyHit</color></b>"
}));
}
GUI.Label(new Rect(10f, 140f, 180f, 20f), "Chat color:");
if (GUI.Button(new Rect(10f, 160f, 180f, 20f), "Green"))
{
	PlayerStatus.SuChatColor = UnityEngine.Color.green;
}
if (GUI.Button(new Rect(10f, 180f, 180f, 20f), "Red"))
{
	PlayerStatus.SuChatColor = UnityEngine.Color.red;
}
if (GUI.Button(new Rect(10f, 200f, 180f, 20f), "Blue"))
{
	PlayerStatus.SuChatColor = UnityEngine.Color.blue;
}
if (GUI.Button(new Rect(10f, 220f, 180f, 20f), "Normal"))
{
	PlayerStatus.SuChatColor = UnityEngine.Color.white;
}
GUI.DragWindow(new Rect(0f, 0f, 10000f, 10000f));
}
>
public float shield;
>
>
>
>
private void SuDrawItem(int windowID)
{
	GUI.backgroundColor = this.Bcolor;
	GUI.contentColor = this.Ccolor;
	this.SuItemAmount = GUI.VerticalSlider(new Rect(460f, 50f, 50f, 230f), this.SuItemAmount, 1000f, 1f);
	GUI.Label(new Rect(450f, 40f, 60f, 20f), this.SuItemAmount.ToString());
	GUI.Label(new Rect(450f, 20f, 60f, 20f), "Amount:");
	PlayerStatus.SuScrollPosition = GUI.BeginScrollView(new Rect(10f, 20f, 440f, 270f), PlayerStatus.SuScrollPosition, new Rect(0f, 0f, 440f, 1500f), false, true);
	for (int i = 0; i < 22; i++)
	{
		for (int j = 0; j < 7; j++)
		{
			if (this.SuCurrentId < 152)
			{
				GUI.Label(new Rect((float)(j * 60), (float)(i * 60), 60f, 60f), this.SuCurrentId.ToString());
				if (GUI.Button(new Rect((float)(j * 60), (float)(i * 60), 60f, 60f), PlayerStatus.SuItemSprites[this.SuCurrentId].texture))
				{
					foreach (global::InventoryItem inventoryItem in ItemManager.Instance.allItems.Values)
					{
						if (inventoryItem.id == this.SuCurrentId)
						{
							global::InventoryItem inventoryItem2 = inventoryItem;
							inventoryItem2.amount = (int)this.SuItemAmount;
							InventoryUI.Instance.AddItemToInventory(inventoryItem2);
							break;
						}
					}
				}
			}
			this.SuCurrentId++;
		}
	}
	this.SuCurrentId = 0;
	GUI.EndScrollView();
	GUI.DragWindow(new Rect(0f, 0f, 10000f, 10000f));
}
>	
>
public void SuDrawPower(int windowID)
{
	GUI.backgroundColor = this.Bcolor;
	GUI.contentColor = this.Ccolor;
	this.SuPowerAmount = GUI.HorizontalSlider(new Rect(255f, 205f, 170f, 30f), this.SuPowerAmount, 1f, 50f);
	GUI.Label(new Rect(255f, 225f, 170f, 30f), "Amount: " + this.SuPowerAmount.ToString());
	for (int i = 0; i < 1; i++)
	{
		this.SuCurrentPwrId = 0;
		for (int j = 0; j < 4; j++)
		{
			this.SuPwrY = (float)(j * 60 + 20);
			for (int k = 0; k < 7; k++)
			{
				this.SuPwrX = (float)(k * 60 + 10);
				if (this.SuCurrentPwrId < 25 && GUI.Button(new Rect(this.SuPwrX, this.SuPwrY, 60f, 60f), PlayerStatus.SuPwrSprites[this.SuCurrentPwrId].texture))
				{
					for (int l = 0; l < (int)this.SuPowerAmount; l++)
					{
						PowerupInventory.Instance.AddPowerup(ItemManager.Instance.allPowerups[this.SuCurrentPwrId].name, ItemManager.Instance.allPowerups[this.SuCurrentPwrId].id, ItemManager.Instance.GetNextId());
					}
				}
				this.SuCurrentPwrId++;
			}
		}
		this.SuCurrentPwrId = 0;
	}
	GUI.DragWindow(new Rect(0f, 0f, 10000f, 10000f));
}
>
>
private void SuDrawMob(int windowID)
{
	GUI.backgroundColor = this.Bcolor;
	GUI.contentColor = this.Ccolor;
	for (int i = 0; i < 14; i++)
	{
		if (GUI.Button(new Rect(10f, (float)i * 20f + 20f, 160f, 20f), MobSpawner.Instance.allMobs[i].name))
		{
			MobSpawner.Instance.ServerSpawnNewMob(MobManager.Instance.GetNextId(), MobSpawner.Instance.allMobs[i].id, PlayerMovement.Instance.GetRb().position, 1f, 1f, Mob.BossType.None, -1);
		}
	}
	GUI.DragWindow(new Rect(0f, 0f, 10000f, 10000f));
	}
>
>
public Vector3 FindTpPos()
{
	Transform playerCam = PlayerMovement.Instance.playerCam;
	RaycastHit raycastHit;
	if (Physics.Raycast(playerCam.position, playerCam.forward, out raycastHit, 1500f))
	{
		Vector3 b = Vector3.zero;
		if (raycastHit.collider.gameObject.layer == LayerMask.NameToLayer("Ground"))
		{
			b = Vector3.one;
		}
		return raycastHit.point + b;
	}
	return Vector3.zero;
}
>
>
>
>
>
public void SuDrawPremium(int windowID)
{
	GUI.backgroundColor = this.Bcolor;
	GUI.contentColor = this.Ccolor;
	if (!this.SuUnlock)
	{
		GUI.DrawTexture(new Rect(125f, 25f, 200f, 200f), PlayerStatus.SuItemSprites[73].texture);
		this.SuPassword = GUI.TextField(new Rect(150f, 125f, 150f, 20f), this.SuPassword);
		if (GUI.Button(new Rect(150f, 105f, 150f, 20f), "Verify") && this.SuPassword == "lmao-not-this-time")
		{
			this.SuUnlock = true
		}
	}
}
>
>
public void SuDrawVisuals(int windowID)
{
	PlayerManager[] array = UnityEngine.Object.FindObjectsOfType<PlayerManager>();
	HitableRock[] array2 = UnityEngine.Object.FindObjectsOfType<HitableRock>();
	this.SuPlayerEsp = GUI.Toggle(new Rect(5f, 20f, 170f, 20f), this.SuPlayerEsp, "Player ESP");
	this.SuCoalEsp = GUI.Toggle(new Rect(5f, 40f, 170f, 20f), this.SuCoalEsp, "Coal ESP");
	this.SuStoneEsp = GUI.Toggle(new Rect(5f, 60f, 170f, 20f), this.SuStoneEsp, "Stone ESP");
	this.SuIronEsp = GUI.Toggle(new Rect(5f, 80f, 170f, 20f), this.SuIronEsp, "Iron ESP");
	this.SuMithrilEsp = GUI.Toggle(new Rect(5f, 100f, 170f, 20f), this.SuMithrilEsp, "Mithril ESP");
	this.SuAdamantiteEsp = GUI.Toggle(new Rect(5f, 120f, 170f, 20f), this.SuAdamantiteEsp, "Adamantite ESP");
	this.SuObamiumEsp = GUI.Toggle(new Rect(5f, 140f, 170f, 20f), this.SuObamiumEsp, "Obamium ESP");
	if (this.SuPlayerEsp)
	{
		for (int i = 0; i < array.Length; i++)
		{
			PlayerStatus.SuLineConnection(PlayerMovement.Instance.GetRb().position, array[i].transform.position, UnityEngine.Color.red);
	}
}
if (this.SuCoalEsp)
{
	for (int j = 0; j < array2.Length; j++)
	{
		if (array2[j].name.ToLower() == "coal")
		{
			PlayerStatus.SuLineConnection(PlayerMovement.Instance.GetRb().position, array2[j].transform.position, UnityEngine.Color.black);
		}
	}
}
GUI.DragWindow(new Rect(0f, 0f, 10000f, 10000f));
}
>
>
public static void SuLineConnection(Vector3 first, Vector3 second, UnityEngine.Color color)
{
	UnityEngine.Object.FindObjectOfType<LineRenderer>().startColor = color;
	UnityEngine.Object.FindObjectOfType<LineRenderer>().endColor = color;
	UnityEngine.Object.FindObjectOfType<LineRenderer>().startWidth = 0.3f;
	UnityEngine.Object.FindObjectOfType<LineRenderer>().endWidth = 0.3f;
	UnityEngine.Object.FindObjectOfType<LineRenderer>().SetPosition(0, first);
	UnityEngine.Object.FindObjectOfType<LineRenderer>().SetPosition(1, second);
}
>
>
public float hp = 100f;
>
>
public int maxHp;
>	
>
public float shield;
>	
>
public int maxShield;
>
>
private bool dead;
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
>
//public enum DamageType
//{
>
//	Mob,
>
//	Player,
>
//	Drown
//}
>
>
public static Rect SuwindowRect = new Rect(20f, 20f, 180f, 280f);
>
>
private bool SuPlayerUi;
>
>
private bool SuExploitUi;
>
>
private bool SuServerUi;
>
>
private bool SuItemUi;
>
>
private bool SuPowerUi;
>
>
private bool SuMobUi;
>
>
public static Rect SuPlayerRect = new Rect(250f, 20f, 150f, 320f);
>
>
public static Rect SuServerRect = new Rect(400f, 20f, 350f, 200f);
>
>
public static Rect SuExploitRect = new Rect(750f, 20f, 200f, 250f);
>
>
public static Rect SuItemRect = new Rect(340f, 340f, 500f, 300f);
>
>
public static Rect SuPowerRect = new Rect(840f, 340f, 440f, 280f);
>
>
public static Rect SuMobRect = new Rect(1340f, 340f, 180f, 310f);
>
>
private bool SuGod;
>
>
private bool SuStamina;
>
>
private bool SuFood;
>
>
private bool SuNoClip;
>
>
private bool SuHover;
>
>
private bool SuClickTp;
>
>
private bool SuAtackSpeed;
>
>
public static bool SuFlightBool;
>
>
public static bool SuInstamineBool;
>
>
public static bool SuInstakillBool;
>
>
public static bool SuNocoinsBool;
>
>
public static bool SuOmegajump;
>
>
public static bool SuSpeed;
>
>
private int SuPlayerButtonsXValue;
>
>
public static List<string> SuPowerupNames;
>
>
public static List<string> SuItemNamesDev = new List<string>();
>
>
public static List<Sprite> SuItemSprites;
>
>
public static Vector2 SuScrollPosition;
>
>
private int SuXpos;
>
>
private int SuYpos;
>
>
private int SuCurrentId;
>
>
private float SuItemAmount;
>
>
private int SuCurrentPwrId;
>
>
public static List<Sprite> SuPwrSprites;
>
>
private int SuPowerPh;
>
>
public static bool SuMuckChat;
>
>
public static bool SuDisableChatOwner;
>
>
private bool SuUnlock;
>
>
public static Rect SuPremiumRect;
>
>
private bool SuPremiumUi;
>
>
private string SuPassword;
>
>
private float SuPwrX;
>
>
private float SuPwrY;
>
>
private bool SuAdvertize;
>
>
private bool SuMainLock;
>
>
private UnityEngine.Color Bcolor;
>
>
private UnityEngine.Color Ccolor;
>
>
private int SuPlayerSelection;
>
>
private int SuPlayersButY;
>
>
public static UnityEngine.Color SuChatColor;
>
>
private string SuVer;
>
>
private string SuCheckedVer;
>
>
private bool SuLockout;
>
>
private bool SuCanCollectData;
>
>
private bool SuDisableWatermark;
>
>
private bool SuVisualsUi;
>
>
public static Rect SuVisualsRect;
>
>
private bool SuItemRain;
>
>
private int SuRainCooldown;
>
>
private int SuRainItemId;
>
>
private bool SuPlayerEsp;
>
>
private bool SuCoalEsp;
>
>
private bool SuIronEsp;
>
>
private bool SuStoneEsp;
>
>
private bool SuMithrilEsp;
>
>
private bool SuAdamantiteEsp;
>
>
private bool SuObamiumEsp;
>
>
private LineRenderer LineRenderer;
>
>
private float SuPowerAmount;
>
>
public enum DamageType
{
>
	Mob,
>
	Player,
>
	Drown
}
>
>
>
>
>
>
>
>
>
>
>
>
>
>