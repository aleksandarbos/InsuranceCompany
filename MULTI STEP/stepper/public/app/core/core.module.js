(function(){
  "use strict"
  
  angular.module('coreModule', ['pascalprecht.translate'])
  .config(['$translateProvider', function ($translateProvider) {
  // add translation tables
  $translateProvider.translations('en', translationsEN);
  $translateProvider.translations('srb', translationsSRB);
  $translateProvider.preferredLanguage('en');
  $translateProvider.fallbackLanguage('en');
}]);




var translationsEN = {
  INSURANCE: 'Travel insurance',
  TYPEOFTRAVEL: 'Type of travel',
  FAMILY: 'Family',
  SELF: 'Individual',
  ADULT: 'Number of adults',
  KIDS: 'Number of kids',
  PURPOSE: 'Travel purpose',
  TOURIST: 'Vacation',
  SPORT: 'Active holiday(Skiing...)',
  BUISNESS: 'Business travel',
  STATE: 'State',
  DAYS: 'Number of days',
  CANCEL: 'CANCEL',
  NEXT: 'NEXT',
  CHOOSE:'CHoose your insurance',
  BUTTON_LANG_SRB: 'Serbian',
  BUTTON_LANG_EN: 'English'
};
 
var translationsSRB= {
  INSURANCE: 'Putno osiguranje',
  TYPEOFTRAVEL: 'Vrsta putovanja',
  FAMILY: 'Porodicno',
  SELF: 'Individualno',
  ADULT: 'Broj odraslih',
  KIDS: 'Broj dece',
  PURPOSE:'Svrha putovanja',
  TOURIST: 'Turisticki',
  SPORT: 'Aktivan odmor(skijanje..)',
  BUISNESS: 'Poslovni put',
  STATE: 'Drzava',
  DAYS: 'Broj dana',
  CANCEL: 'Odustani',
  NEXT: 'DALJE',
  CHOOSE:'Odabir putovanja'
  BUTTON_LANG_SRB: 'Srpski',
  BUTTON_LANG_EN: 'Engleski'
};





})();

