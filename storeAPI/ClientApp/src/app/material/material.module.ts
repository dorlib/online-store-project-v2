import { NgModule } from '@angular/core';
import { MatTableModule } from '@angular/material/table';
import { MatIconModule } from '@angular/material/icon';
import { MatDialogModule } from '@angular/material/dialog';
import { MatSnackBarModule } from '@angular/material/snack-bar';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatToolbarModule } from '@angular/material/toolbar';

const material = [
  MatTableModule,
  MatDialogModule,
  MatIconModule,
  MatSnackBarModule,
  MatFormFieldModule,
  MatInputModule,
  MatToolbarModule,
]

@NgModule({
  declarations: [],
  imports: [],
  exports: [material]
})
export class MaterialModule { }