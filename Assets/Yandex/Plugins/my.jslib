mergeInto(LibraryManager.library, {

  AdRelive : function(){

    ysdk.adv.showRewardedVideo({
      callbacks: {
        onOpen: () => {
          console.log('Video ad open.');
        },
        onRewarded: () => {
          console.log('Rewarded!');
        },
        onClose: () => {
          console.log('Video ad closed.');
          myGameInstance.SendMessage("SpawnPlayerPoints", "RelivePlayer");
        }, 
        onError: (e) => {
          console.log('Error while open video ad:', e);
        }
      }
    })
  },

  StartAdBanner : function(){

    ysdk.adv.showFullscreenAdv({
      callbacks: {
        onClose: function(wasShown) {
          myGameInstance.SendMessage("SpawnPlayerPoints", "OffPause");
          // some action after close
        },
        onError: function(error) {
          myGameInstance.SendMessage("SpawnPlayerPoints", "OffPause");
          // some action on error
        }
      }
    })
  },

  GetLang : function() {
    var lang = ysdk.environment.i18n.lang;
    var bufferSize = lengthBytesUTF8(lang) + 1;
    var buffer = _malloc(bufferSize);
    stringToUTF8(lang, buffer, bufferSize);
    return buffer;
  },

  StartGame : function(){
    initPlayer();
  },

  SaveExtern : function(date){
    var dateString = UTF8ToString(date);
    console.log(dateString);
    var myobj = JSON.parse(dateString);
    player.setData(myobj);
  },

  LoadExtern : function(){
    initPlayer().then(() => {
      return player.getData();
    }).then(_date => {
      const myJSON = JSON.stringify(_date);
      myGameInstance.SendMessage('Progress', 'SetPlayerInfo', myJSON);
    });
  }

});