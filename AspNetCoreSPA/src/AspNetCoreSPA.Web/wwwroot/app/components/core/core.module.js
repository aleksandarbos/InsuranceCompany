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
  BUSINESS: 'Business travel',
  STATE: 'State',
  DAYS: 'Number of days',
  CANCEL: 'CANCEL',
  NEXT: 'NEXT',
  PREVIOUS:'PREVIOUS',
  CHOOSE:'Choose your insurance',
  BUTTON_LANG_SRB: 'Serbian',
  BUTTON_LANG_EN: 'English',
  OFFER:'Package offer',
  PACKAGE:'Choose package',
  PRICE:'Price',
  PACKAGE1:'Standard: Complete medical assistance is defined standard package cover.The cost of transport to the hospital, treatment and hospitalization. Medical and orthopedic equipment overwritten by a doctor.Treatment of acute toothache amounting to 150 €. Back in the patient'+'s home country in the amount of up to € 2,000.',
  PACKAGE2:'Comfort: Complete medical assistance is defined comfort package cover. The cost of transport to the hospital, treatment and hospitalization. Medical and orthopedic equipment overwritten by a doctor.Treatment of acute toothache of up to € 300. Back patient'+'s home of up to € 7,000.Loss or theft of luggage up to 100 €. Translation service.',
  PACKAGE3:'Exclusive: Complete medical assistance is defined exclusive package cover.The cost of transport to the hospital, treatment and hospitalization. Medical and orthopedic equipment overwritten by a doctor.Treatment of acute toothache of up to € 300. Back patient'+'s home of up to € 10,000.Loss or theft of baggage amounting to 200 €.Translation service. Return of children who have lost control (air ticket).Finding a lawyer at the expense of the insured.',
  USER:'User',
  NAME:'Name',
  SURNAME:'Surname',
  DATEBIRTH:'Date of birth',
  PASSPORT:'Passport number',
  SEX:'Sex',
  MALE:'Male',
  FEMALE:'Female',
  OTHER:'Other',
  INFO:'Personal info',
  PAYMENT:'Billing options',
  FINISH: 'Finish',
  INSURANCE_WIZARD: 'Insurance wizard',
  DATE: 'Enter date',
    HOME: 'Home',
    ABOUT: 'About',
    LOGO_PHOTO: '/images/logo_full_white.png',
    ENGLISH: 'ENGLISH',
    SERBIAN: 'SERBIAN'

};
 
var translationsSRB= {
  INSURANCE: 'Putno osiguranje',
  TYPEOFTRAVEL: 'Vrsta putovanja',
  FAMILY: 'Porodično',
  SELF: 'Individualno',
  ADULT: 'Broj odraslih',
  KIDS: 'Broj dece',
  PURPOSE:'Svrha putovanja',
  TOURIST: 'Turistički',
  SPORT: 'Aktivan odmor (skijanje..)',
  BUSINESS: 'Poslovni put',
  STATE: 'Država',
  DAYS: 'Broj dana',
  CANCEL: 'ODUSTANI',
  NEXT: 'DALJE',
  PREVIOUS:'NAZAD',
  CHOOSE:'Odabir putovanja',
  BUTTON_LANG_SRB: 'Srpski',
  BUTTON_LANG_EN: 'Engleski',
  OFFER:'Ponuda paketa',
  PACKAGE:'Izaberite paket',
  PRICE:'Cena',
  PACKAGE1:'Standard:Kompletna medicinska asistencija definisana standard paketom pokrića. Troškovi prevoza do bolnice, lečenja i hospitalizacije. Medicinska i ortopedska oprema prepisana od lekara. Lečenje akutne zubobolje u visini do 150€. Povratak pacijenta u domovinu u visini do 2.000€.',
  PACKAGE2:'Komfort: Kompletna medicinska asistencija definisana komfort paketom pokrića. Troškovi prevoza do bolnice, lečenja i hospitalizacije. Medicinska i ortopedska oprema prepisana od lekara. Lečenje akutne zubobolje u visini do 300€. Povratak pacijenta u domovinu u visini do 7.000€. Gubitak ili krađa prtljaga u visini do 100€. Prevodilačke usluge.',
  PACKAGE3:'Ekskluziv: Kompletna medicinska asistencija definisana ekskluziv paketom pokrića. Troškovi prevoza do bolnice, lečenja i hospitalizacije. Medicinska i ortopedska oprema prepisana od lekara. Lečenje akutne zubobolje u visini do 300€. Povratak pacijenta u domovinu u visini do 10.000€. Gubitak ili krađa prtljaga u visini do 200€. Prevodilačke usluge. Povratak dece koja su ostala bez nadzora (avionska karta). Pronalaženje advokata na račun osiguranika.',
  USER:'Korisnik',
  NAME:'Ime',
  SURNAME:'Prezime',
  DATEBIRTH:'Datum rođenja',
  PASSPORT:'Broj pasoša',
  SEX:'Pol',
  MALE:'Muški',
  FEMALE:'Ženski',
  OTHER:'Drugo',
  INFO:'Informacije o korisniku',
  PAYMENT:'Plaćanje',
  FINISH: 'Završi',
  INSURANCE_WIZARD: 'Osiguravajući čarobnjak',
  DATE: 'Unesi datum',
  HOME: 'Početna',
  ABOUT: 'O nama',
  LOGO_PHOTO: '/images/logo_full_white_srb.png',
  ENGLISH: 'ENGLESKI',
  SERBIAN: 'SRPSKI'


};





})();

