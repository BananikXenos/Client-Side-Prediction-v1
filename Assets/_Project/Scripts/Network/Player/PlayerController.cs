using LindoNoxStudio.Network.Input;
using Unity.Netcode;
using UnityEngine;

namespace LindoNoxStudio.Network.Player
{
    public class PlayerController : NetworkBehaviour
    {
        public void OnInput(ClientInputState input)
        {
            // Todo: Moving the player based on the input
        }

        public PlayerState GetState(uint tick, ClientInputState nextInput)
        {
            PlayerState state = new PlayerState();
            state.SetUp(tick, nextInput);
            
            return state;
        }
    }
}