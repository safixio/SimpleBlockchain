import { Component, Input, OnInit } from '@angular/core';
import { Block } from 'src/app/models/block';

@Component({
  selector: 'app-block',
  templateUrl: './block.component.html',
  styleUrls: ['./block.component.css']
})
export class BlockComponent implements OnInit {

  @Input() block: Block;

  constructor() { }

  ngOnInit(): void {
  }

}
