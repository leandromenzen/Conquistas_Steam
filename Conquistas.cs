using Steamworks;  //Biblioteca Necessaria para funcionar
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Conquistas.Steamworks
{

public class Conquistas : MonoBehaviour
{
private void Update()
{
  if (!SteamManager.Initialized) { return; } //Inicializar

  if (!Input.GetKeyDown(KeyCode.Z)) { return; } //Pressionar uma tecla para testar conquista, aqui pode-se mudar por um OnTriggerEnter ou outro evento ou variavel que precisar.

  // SteamUserStats.ResetAllStats(true); // Manter essa função em true caso queira resetar todo progresso de conquistas.

  SteamUserStats.SetAchievement("ACH_TEST"); // Colocar nome da conquista dentro do SteamWorks

  SteamUserStats.StoreStats();

}
}
}
