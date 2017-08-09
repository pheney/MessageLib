public static class Messages
{
    public static class MonoBehaviour
    {
        public static string AWAKE = "Awake";
        public static string FIXEDUPDATE = "FixedUpdate";
        public static string LATEUPDATE = "LateUpdate";
        public static string ONAUDIOFILTERREAD = "OnAudioFilterRead";
        public static string ONDESTROY = "OnDestroy";
        public static string ONDISABLE = "OnDisable";
        public static string ONENABLE = "OnEnable";
        public static string ONJOINTBREAK = "OnJointBreak";
        public static string ONJOINTBREAK2D = "OnJointBreak2D";
        public static string ONTRANSFORMCHILDRENCHANGED = "OnTransformChildrenChanged";
        public static string ONTRANSFORMPARENTCHANGED = "OnTransformParentChanged";
        public static string RESET = "Reset";
        public static string START = "Start";
        public static string UPDATE = "Update";
    }

    public static class Collision
    {
        public static string ONCOLLISIONENTER = "OnCollisionEnter";
        public static string ONCOLLISIONENTER2D = "OnCollisionEnter2D";
        public static string ONCOLLISIONEXIT = "OnCollisionExit";
        public static string ONCOLLISIONEXIT2D = "OnCollisionExit2D";
        public static string ONCOLLISIONSTAY = "OnCollisionStay";
        public static string ONCOLLISIONSTAY2D = "OnCollisionStay2D";
        public static string ONCONTROLLERCOLLIDERHIT = "OnControllerColliderHit";
    }
    
    public static class Trigger
    {
        public static string ONTRIGGERENTER = "OnTriggerEnter";
        public static string ONTRIGGERENTER2D = "OnTriggerEnter2D";
        public static string ONTRIGGEREXIT = "OnTriggerExit";
        public static string ONTRIGGEREXIT2D = "OnTriggerExit2D";
        public static string ONTRIGGERSTAY = "OnTriggerStay";
        public static string ONTRIGGERSTAY2D = "OnTriggerStay2D";
    }

    public static class Render
    {
        public static string ONBECAMEINVISIBLE = "OnBecameInvisible";
        public static string ONBECAMEVISIBLE = "OnBecameVisible";
        public static string ONPOSTRENDER = "OnPostRender";
        public static string ONPRECULL = "OnPreCull";
        public static string ONPRERENDER = "OnPreRender";
        public static string ONRENDERIMAGE = "OnRenderImage";
        public static string ONRENDEROBJECT = "OnRenderObject";
        public static string ONWILLRENDEROBJECT = "OnWillRenderObject";
    }

    public static class Application
    {
        public static string ONAPPLICATIONFOCUS = "OnApplicationFocus";
        public static string ONAPPLICATIONPAUSE = "OnApplicationPause";
        public static string ONAPPLICATIONQUIT = "OnApplicationQuit";
    }

    public static class Network
    {
        public static string ONCONNECTEDTOSERVER = "OnConnectedToServer";
        public static string ONDISCONNECTEDFROMSERVER = "OnDisconnectedFromServer";
        public static string ONFAILEDTOCONNECT = "OnFailedToConnect";
        public static string ONFAILEDTOCONNECTTOMASTERSERVER = "OnFailedToConnectToMasterServer";
        public static string ONMASTERSERVEREVENT = "OnMasterServerEvent";
        public static string ONNETWORKINSTANTIATE = "OnNetworkInstantiate";
        public static string ONPLAYERCONNECTED = "OnPlayerConnected";
        public static string ONPLAYERDISCONNECTED = "OnPlayerDisconnected";
        public static string ONSERIALIZENETWORKVIEW = "OnSerializeNetworkView";
        public static string ONSERVERINITIALIZED = "OnServerInitialized";
    }

    public static class Editor
    {
        public static string ONDRAWGIZMOS = "OnDrawGizmos";
        public static string ONDRAWGIZMOSSELECTED = "OnDrawGizmosSelected";
        public static string ONVALIDATE = "OnValidate";
    }
    public static class Particle
    {
        public static string ONPARTICLECOLLISION = "OnParticleCollision";
        public static string ONPARTICLETRIGGER = "OnParticleTrigger";
    }
    public static class Animator
    {
        public static string ONANIMATORIK = "OnAnimatorIK";
        public static string ONANIMATORMOVE = "OnAnimatorMove";
    }
}