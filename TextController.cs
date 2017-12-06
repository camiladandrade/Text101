using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {
	public Text text;
	
	private enum States {cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, corridor_0,
	                     freedom, stairs_0, floor, closet_door, stairs_1, corridor_1, in_closet, corridor_2,
	                     stairs_2, corridor_3, courtyard, lose};
	private States myState;

	// Use this for initialization
	void Start () {
		myState = States.cell;
	
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if (myState == States.cell){
			cell();
		}
		else if (myState == States.sheets_0){
			sheets_0();
		}
		else if (myState == States.mirror){
			mirror();
		}
		else if (myState == States.cell_mirror){
			cell_mirror();			
		}
		else if (myState == States.sheets_1){
			sheets_1();
		}
		else if (myState == States.lock_1){
			lock_1();
		}
		else if (myState == States.lock_0){
			lock_0();
		}
		else if (myState == States.corridor_0){
			corridor_0();
		}
		else if (myState == States.stairs_0){
			stairs_0();
		}
		else if (myState == States.floor){
			floor();
		}
		else if (myState == States.closet_door){
			closet_door();
		}
		else if (myState == States.corridor_1){
			corridor_1();
		}
		else if (myState == States.stairs_1){
			stairs_1();
		}
		else if (myState == States.in_closet){
			in_closet();
		}
		else if (myState == States.corridor_2){
			corridor_2();
		}
		else if (myState == States.stairs_2){
			stairs_2();
		}
		else if (myState == States.corridor_3){
			corridor_3();
		}
		else if (myState == States.courtyard){
			courtyard();
		}
		else if (myState == States.lose){
			lose();
		}
	}
	void cell(){
		text.text = "Nao sei o que voce aprontou ontem a noite, mas voce esta numa cela.\n" +
					"Provavelmente voce eh inocente, mas hoje eh domingo e seu advogado esta na praia.\n" +
					"A fechadura da cela eh aberta com um codigo, que esta no seu bolso, mas voce nao consegue ver o teclado.\n\n" +
					"Aperte 'C' para ver o cobertor, 'E' para ver o Espelho, e 'F' para ver a Fechadura";
					
		if (Input.GetKeyDown (KeyCode.C)){
			myState = States.sheets_0;			
		}
		else if (Input.GetKeyDown (KeyCode.E)){
			myState = States.mirror;
		}
		else if (Input.GetKeyDown (KeyCode.F)){
			myState = States.lock_0;
		}
	}
	
	void sheets_0(){
		text.text = "Se eu fosse voce nao dormiria nisso. Serio.\n" +
					"Talvez voce encontre algo mais util do outro lado da cela\n\n" +
					"Aperte 'R' para Retornar";
		if (Input.GetKeyDown (KeyCode.R)){
			myState = States.cell;
			
		}
	}
	
	void mirror(){
		text.text = "Voce encontrou um espelho. Acho que voce pode usa-lo\n\n" +
					"Aperte 'R' para Retornar, 'P' para Pegar o espelho";
		if (Input.GetKeyDown (KeyCode.R)){
			myState = States.cell;
		}
		else if (Input.GetKeyDown (KeyCode.P)){
			myState = States.cell_mirror;
		}
	}
	
	void cell_mirror(){
		text.text = "Massa! Agora, onde voce acha que pode usar o espelho?\n\n" +
					"Aperte 'C' para ver o cobertor, ou 'F' para Fechadura";
		if (Input.GetKeyDown (KeyCode.C)){
			myState = States.sheets_1;
		}
		else if (Input.GetKeyDown (KeyCode.F)){
			myState = States.lock_1;
		}	
	}
		
	void sheets_1(){
		text.text = "Nao, acho que ainda nao eh aqui \n\n" +
					"Aperte 'R' para Retornar";
		if (Input.GetKeyDown (KeyCode.R)){
				myState = States.cell_mirror;
		}
	}
	
	void lock_0(){
		text.text = "Essa eh a fechadura. Mas voce nao consegue ver o teclado\n\n" +
					"Se voce tivesse algo para poder ve-lo\n\n" +
					"Aperte 'R' para Retornar";
		if (Input.GetKeyDown (KeyCode.R)){
			myState = States.cell;
		}
	}
	void lock_1(){
		text.text = "Calma. voce esta quase la.\n" +
					"Abra a fechadura e saia livre, ou volte e espere seu advogado se recuperar da insolaçao\n\n" +
					"Aperte 'A' para Abrir, 'R' para Retornar";
		if (Input.GetKeyDown (KeyCode.A)){
			myState = States.corridor_0;}
		else if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.cell_mirror;
		}
	}
	
	void corridor_0(){
		text.text = "So que nao! Voce agora esta no corredor, e eu acho que o guarda te viu\n" +
					"Rapido, ache a saida antes que voce va para a solitaria\n\n" + 
					"Apete 'E' para ver as Escadas, 'C' para ver o Chao, ou 'V' para ver o Vestiario, " ;
		if (Input.GetKeyDown (KeyCode.E)){
			myState = States.stairs_0;
		}
		else if (Input.GetKeyDown (KeyCode.C)){
			myState = States.floor;
		}
		else if (Input.GetKeyDown (KeyCode.V)){
			myState = States.closet_door;
		}
	}
	
	void stairs_0(){
		text.text = "Essa escada vai direto para o refeitorio. La vai esta cheio de policiais\n" +
					"Tem certeza que quer ir ate la?\n\n" +
					"Aperte 'R' para Retornar, ou 'S' para Subir";
		if (Input.GetKeyDown (KeyCode.R)){
			myState = States.corridor_0;
		}
		else if (Input.GetKeyDown (KeyCode.S)){
			myState = States.lose;
		}
	}
	void lose(){
		text.text = "Que pena, os policiais te viram e te levaram novamente para a sua cela\n\n" +
					"Aperte 'J' para Jogar novamente.";
		if (Input.GetKeyDown (KeyCode.J)){
			myState = States.cell;
		}
	}
	void floor(){
		text.text = "Ok. Voce encontrou um clip de papel. Isso pode ser utili\n\n" +
					"Aperte 'P' para Pegar, 'R' para Retornar";
		if (Input.GetKeyDown (KeyCode.P)){
			myState = States.corridor_1;
		}
		else if (Input.GetKeyDown (KeyCode.R)){
			myState = States.corridor_0;
		}
	} 
	
	void closet_door(){
		text.text = "Esse eh o vestiario. Acho que voce pode encontrar algo interessante ai dentro. " +
					"Voce so precisa encontrar algo para abrir a porta\n\n" +
					"Aperte 'R' para Retornar";
		if (Input.GetKeyDown (KeyCode.R)){
			myState = States.corridor_0;
		}
	}
	
	void corridor_1(){
		text.text = "Ok, agora onde voce quer experimentar esse seu achado?\n\n" +
					"Aperte 'V' para ver o Vestiario, e 'E' para Escadas";
		if (Input.GetKeyDown (KeyCode.V)){
			myState = States.in_closet;
		}
		else if (Input.GetKeyDown (KeyCode.E)){
			myState = States.stairs_1;
		}
	}
	
	void stairs_1(){
		text.text = "Essa escada vai direto para o refeitorio. La vai esta cheio de policiais\n" +
					"Tem certeza que quer ir ate la?\n\n" +
					"Aperte 'R' para Retornar, ou 'S' para Subir";
		if (Input.GetKeyDown (KeyCode.R)){
			myState = States.corridor_1;
		}
		else if (Input.GetKeyDown (KeyCode.S)){
			myState = States.lose;
		}
	}
	
	void in_closet(){
		text.text = "Voce esta dentro do vestiario. Tem um armario aberto com um uniforme de policial, " +
					"mas que a sorte a sua, nao? Va ate la e vista a roupa.\n\n" +
					"Aperte 'V' para Vestir o uniforme, 'R' para Retornar";
		if (Input.GetKeyDown (KeyCode.V)){
			myState = States.corridor_3;
		}
		else if (Input.GetKeyDown (KeyCode.R)){
			myState = States.corridor_2;
		}
	}
	
	void corridor_2(){
		text.text = "Voce voltou para o corredor, e eu tenho quase certeza que o oficial esta perto.\n\n" +
					"Aperte 'V' para Voltar ao Vestiario, ou 'E' para subir as Escadas.";
		if (Input.GetKeyDown (KeyCode.V)){
			myState = States.in_closet;
		}
		else if (Input.GetKeyDown (KeyCode.E)){
			myState = States.stairs_2;
		}
	}
	
	void stairs_2(){
		text.text = "Essa escada vai direto para o refeitorio. La vai esta cheio de policiais\n" +
					"Tem certeza que quer ir ate la?\n\n" +
					"Aperte 'R' para Retornar, ou 'S' para Subir";
		if (Input.GetKeyDown (KeyCode.R)){
			myState = States.corridor_2;
		}
		else if (Input.GetKeyDown (KeyCode.S)){
			myState = States.lose;
		}
	}
	
	void corridor_3(){
		text.text = "Vejo que voce prefere fugir a esperar pelo seu advogado. Ok, suba as escadas para ir para o Patio\n\n" +
					"Aperte 'T' para voltar ao Vestiario, ou 'E' para subir as Escadas";
		if (Input.GetKeyDown (KeyCode.E)){
			myState = States.courtyard;
		}
		else if (Input.GetKeyDown (KeyCode.T)){
			myState = States.in_closet;
		}
	}
	
		void courtyard(){
			text.text = "Parabens! Voce esta livre e ninguem percebeu. Voce deve ser um mestre dos disfarces mesmo." +
						" Agora voce pode ir procurar saber o que houve noite passada.\n\n" +
						"Aperte 'J' para Jogar novamente";
			if (Input.GetKeyDown (KeyCode.J)){
				myState = States.cell;
			}
		}
}
