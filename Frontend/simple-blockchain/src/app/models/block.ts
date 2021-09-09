import { Transaction } from "./transaction";

export class Block {
    index: number;
    timeStamp: Date;
    hash: string;
    prevHash: string;
    nonce: number;
    transactions: Transaction[];
}