��U S E   [ r e v i e w ]  
 G O  
 / * * * * * *   O b j e c t :     T a b l e   [ d b o ] . [ c u i s i n e ]         S c r i p t   D a t e :   1 2 / 7 / 2 0 1 6   1 : 5 1 : 5 6   P M   * * * * * * /  
 S E T   A N S I _ N U L L S   O N  
 G O  
 S E T   Q U O T E D _ I D E N T I F I E R   O N  
 G O  
 C R E A T E   T A B L E   [ d b o ] . [ c u i s i n e ] (  
 	 [ n a m e ]   [ v a r c h a r ] ( 2 5 5 )   N U L L ,  
 	 [ i d ]   [ i n t ]   I D E N T I T Y ( 1 , 1 )   N O T   N U L L  
 )   O N   [ P R I M A R Y ]  
  
 G O  
 / * * * * * *   O b j e c t :     T a b l e   [ d b o ] . [ r e s t a u r a n t ]         S c r i p t   D a t e :   1 2 / 7 / 2 0 1 6   1 : 5 1 : 5 6   P M   * * * * * * /  
 S E T   A N S I _ N U L L S   O N  
 G O  
 S E T   Q U O T E D _ I D E N T I F I E R   O N  
 G O  
 C R E A T E   T A B L E   [ d b o ] . [ r e s t a u r a n t ] (  
 	 [ n a m e ]   [ v a r c h a r ] ( 2 2 5 )   N U L L ,  
 	 [ d e s c r i p t i o n ]   [ v a r c h a r ] ( 2 5 5 )   N U L L ,  
 	 [ c u i s i n e _ i d ]   [ i n t ]   N U L L ,  
 	 [ i d ]   [ i n t ]   I D E N T I T Y ( 1 , 1 )   N O T   N U L L  
 )   O N   [ P R I M A R Y ]  
  
 G O  
 
