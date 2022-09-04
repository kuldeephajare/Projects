package com.txn.controller.dto;

import lombok.Builder;
import lombok.Getter;
import lombok.Setter;

@Getter
@Setter
@Builder
public class AppointmentFormDto {

    private String name;

    private String gender;

    private String mobile;

    private int age;
}
